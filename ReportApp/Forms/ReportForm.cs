using System.Text;
using ReportApp.Abstractions;
using ReportApp.Models;

namespace ReportApp
{
    public partial class ReportForm : Form
    {
        private readonly IOperatorService _operatorService;
        private readonly IRecordService _recordService;

        public ReportForm(IOperatorService operatorService, IRecordService recordService)
        {
            InitializeComponent();
            _operatorService = operatorService;
            _recordService = recordService;

            string currentDate = DateTime.Now.ToString("dd.MM.yy");

            foreach (Operator op in _operatorService.Operators)
            {
                listBox1.Items.Add($"{op.Name} {_recordService.GetOpTotal(op):F2}");
            }

            listBox1.Items.Insert(0, $"{currentDate} Тотал {_recordService.GetAllTotal():F2}");

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
