using ReportApp.Abstractions;
using System.Data;


namespace ReportApp
{
    public partial class EditOperatorForm : Form
    {
        private readonly IOperatorService _operatorService;
        private readonly string _operatorName;

        public EditOperatorForm(string operatorName, IOperatorService operatorService)
        {
            if (operatorName != null)
            {
                InitializeComponent();
                _operatorService = operatorService;
                _operatorName = operatorName;

                foreach (var Id in _operatorService.GetOperator(operatorName).Ids)
                {
                    textBox1.AppendText($"{Id}, ");
                }

                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.TrimEnd(',', ' ');
                }                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void AcceptEditOperatorButton_Click(object sender, EventArgs e)
        {
            var newIds = textBox1.Text.Split(',').Select(id => id.Trim()).ToList();

            _operatorService.EditOperator(_operatorService.GetOperator(_operatorName), newIds);

            this.DialogResult = DialogResult.OK;

        }


    }
}
