using System.Formats.Asn1;
using System.Globalization;
using System.Xml.Linq;
using CsvHelper;
using DatingApp.Classes;
using DatingApp.Interfaces;
using Newtonsoft.Json;

namespace DatingApp
{
    public partial class MainForm : Form
    {
        private readonly IOperatorService _operatorService;
        private readonly IDataProcessor _dataProcessor;

        public MainForm(IOperatorService operatorService, IDataProcessor dataProcessor)
        {
            InitializeComponent();
            _operatorService = operatorService;
            _dataProcessor = dataProcessor;
        }

        private void textOutput(object sender, EventArgs e)
        {

        }

        private void BrowseCsv_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RefreshListBox1();

                    List<Record> consolidatedRecords = _dataProcessor.ProcessData(openFileDialog.FileNames);

                    var operatorRecords = _operatorService.GetOperatorRecords(consolidatedRecords);

                    foreach (var (name, records, totalBonuses) in operatorRecords)
                    {
                        listBox1.Items.Add($"Оператор {name}:\n");

                        foreach (var record in records)
                        {
                            listBox1.Items.Add($"Id: {record._id}, Леди: {record._lady}, Бонусы: {record._bonuses:F2}");
                        }

                        listBox1.Items.Add($" Сумма бонусов: {totalBonuses:F2}\n");
                    }

                }

            }

        }

        private void RefreshListBox1()
        {
            listBox1.Items.Clear();


        }

        private void RefreshListBox()
        {
            listBox2.Items.Clear();

            foreach (Operator op in _operatorService.Operators)
            {
                listBox2.Items.Add(op.Name + ": " + string.Join(", ", op.Ids));
            }
        }

        private void AddOperator_Click(object sender, EventArgs e)
        {
            AddOperatorForm addOpForm = new AddOperatorForm(_operatorService);

            if (addOpForm.ShowDialog() == DialogResult.OK)
            {
                RefreshListBox();
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("operators.json"))
            {
                string jsonFromFile = File.ReadAllText("operators.json");

                _operatorService.LoadExistData(jsonFromFile);

                RefreshListBox();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(_operatorService.Operators);
            File.WriteAllText("operators.json", json);
        }

        private void DeleteOperator_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                _operatorService.DeleteOperator(listBox2.SelectedItem.ToString());

                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите Оператора из списка, перед удалением.");
            }



        }

        private void EditOperator_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                if (listBox2.SelectedItem != null)
                {
                    string selectedItemText = listBox2.SelectedItem.ToString();
                    string opName = selectedItemText.Split(':')[0];

                    Operator opToEdit = _operatorService.Operators.Find(op => op.Name == opName);

                    if (opToEdit != null)
                    {
                        EditOperatorForm editOpForm = new EditOperatorForm(opToEdit, _operatorService);
                        var result = editOpForm.ShowDialog();
                        RefreshListBox();
                    }
                    else
                    {
                        MessageBox.Show("Выбранный Оператор не найден.");
                    }
                }

                else
                {
                    MessageBox.Show("Пожалуйста, выберите Оператора для изменения.");
                }
            }
        }
        private void MakeReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(_operatorService);

            if (reportForm.ShowDialog() == DialogResult.OK)
            {
                _operatorService.DeleteAllRecords();
                listBox1.Items.Clear();
            }

        }

        private void EarseListBoxButton_Click(object sender, EventArgs e)
        {
            _operatorService.Records.Clear();

            listBox1.Items.Clear();
        }
    }  
}

