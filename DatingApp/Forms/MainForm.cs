using ReportApp.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using ReportApp.Models;

namespace ReportApp
{
    public partial class MainForm : Form
    {
        private readonly IOperatorService _operatorService;
        private readonly IDataProcessor _dataProcessor;
        private readonly IRecordService _recordService;
        private readonly IServiceProvider _serviceProvider;
        private readonly ISessionDataService _sessionDataService;

        public MainForm(IOperatorService operatorService, IDataProcessor dataProcessor, IRecordService recordService, 
            IServiceProvider serviceProvider, ISessionDataService sessionDataService)
        {
            InitializeComponent();
            _operatorService = operatorService;
            _dataProcessor = dataProcessor;
            _recordService = recordService;
            _serviceProvider = serviceProvider;
            _sessionDataService = sessionDataService;
        }

        private void textOutput(object sender, EventArgs e){}

        private void Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RefreshListBox1();

                    _dataProcessor.ProcessData(openFileDialog.FileNames);

                    foreach (var Operator in _operatorService.Operators)
                    {
                        listBox1.Items.Add($"�������� {Operator.Name}:\n");

                        var operatorRecords = _recordService.GetOpRecords(Operator);

                        foreach (var record in operatorRecords)
                        {
                            listBox1.Items.Add($"Id: {record.Id}, ����: {record.Lady}, ������: {record.Bonuses:F2}");
                        }

                        listBox1.Items.Add($" ����� �������: {_recordService.GetOpTotal(Operator):F2}\n");
                    }

                }

            }

        }

        private void RefreshListBox1() => listBox1.Items.Clear();

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
            var addOpForm = _serviceProvider.GetRequiredService<AddOperatorForm>();

            if (addOpForm.ShowDialog() == DialogResult.OK)
            {
                RefreshListBox();
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            _sessionDataService.StartSessionLoad();
            RefreshListBox();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => _sessionDataService.EndSessionSave();

        private void DeleteOperator_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                _operatorService.DeleteOperator(listBox2.SelectedItem.ToString());

                RefreshListBox();
            }
            else
            {
                MessageBox.Show("����������, �������� ��������� �� ������, ����� ���������.");
            }



        }

        private void EditOperator_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string operatorName = listBox2.SelectedItem.ToString().Split(':')[0];

                if (operatorName != null)
                {
                    var editOpForm = new EditOperatorForm(operatorName, _serviceProvider.GetRequiredService<IOperatorService>());
                    editOpForm.ShowDialog();
                    RefreshListBox();
                }
                else
                {
                    MessageBox.Show("��������� �������� �� ������.");
                }
            }

            else
            {
                MessageBox.Show("����������, �������� ��������� ��� ���������.");
            }
            
        }
        private void MakeReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = _serviceProvider.GetRequiredService<ReportForm>();

            if (reportForm.ShowDialog() == DialogResult.OK)
            {
                _recordService.DeleteAllRecords();
                listBox1.Items.Clear();
            }

        }

        private void EarseListBoxButton_Click(object sender, EventArgs e)
        {
            _recordService.DeleteAllRecords();
            listBox1.Items.Clear();
        }
    }  
}

