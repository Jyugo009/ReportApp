using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DatingApp.Classes;
using DatingApp.Interfaces;

namespace DatingApp
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
