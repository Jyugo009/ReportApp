using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatingApp
{
    public partial class ReportForm : Form
    {
        private List<Record> records;

        private List<Operator> operators;

        public ReportForm(List<Record> records, List<Operator> operators)
        {
            InitializeComponent();
            this.operators = operators;
            this.records = records;
            string currentDate = DateTime.Now.ToString("dd.MM.yy");
            List<Record> exactRecords = new List<Record>();




            foreach (Operator op in operators)
            {
                var opRecords = records.Where(r => op.Ids.Contains(r.id)).ToList();

                listBox1.Items.Add($"{op.Name} {opRecords.Sum(record => record.bonuses):F2}");

                exactRecords.AddRange(opRecords);
            }

            listBox1.Items.Insert(0, $"{currentDate} Тотал {exactRecords.Sum(r => r.bonuses):F2}");

        }

        private void CopyAndDoneButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            foreach (var item in listBox1.Items)
            {
                sb.AppendLine(item.ToString());
            }

            Clipboard.SetText(sb.ToString());
            this.DialogResult = DialogResult.OK;

        }
    }
}
