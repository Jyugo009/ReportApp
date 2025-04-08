using System.Data;
using ReportApp.Abstractions;

namespace ReportApp
{
    public partial class AddOperatorForm : Form
    {
        private readonly IOperatorService _operatorService;

        public AddOperatorForm(IOperatorService operatorService)
        {
            InitializeComponent();
            _operatorService = operatorService;
        }

        private void AcceptAddOperatorButton_Click(object sender, EventArgs e)
        {
            List<string> ids = textBox2.Text.Split(',').Select(id => id.Trim()).ToList();

            _operatorService.AddOperator(textBox1.Text, ids);

            this.DialogResult = DialogResult.OK;
        }        

    }
}
