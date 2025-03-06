using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatingApp.Classes;
using DatingApp.Interfaces;

namespace DatingApp
{
    public partial class ReportForm : Form
    {
       private readonly IOperatorService _operatorService;

        public ReportForm(IOperatorService operatorService)
        {
            InitializeComponent();
            _operatorService = operatorService;
            string currentDate = DateTime.Now.ToString("dd.MM.yy");
            List<Record> exactRecords = new List<Record>();




            foreach (Operator op in _operatorService.Operators)
            {
                var opRecords = _operatorService.Records.Where(r => op.Ids.Contains(r._id)).ToList();

                listBox1.Items.Add($"{op.Name} {opRecords.Sum(record => record._bonuses):F2}");

                exactRecords.AddRange(opRecords);
            }

            listBox1.Items.Insert(0, $"{currentDate} Тотал {exactRecords.Sum(r => r._bonuses):F2}");

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
