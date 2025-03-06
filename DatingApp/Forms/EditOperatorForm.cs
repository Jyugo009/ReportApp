using DatingApp.Classes;
using DatingApp.Interfaces;
using Newtonsoft.Json;
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

namespace DatingApp
{
    public partial class EditOperatorForm : Form
    {
        readonly IOperatorService _operatorService;
        readonly Operator opToEdit;

        public EditOperatorForm(Operator opToEdit, IOperatorService operatorService)
        {
            if (opToEdit != null)
            {
                InitializeComponent();
                _operatorService = operatorService;
                this.opToEdit = opToEdit;

                foreach (var Id in opToEdit.Ids)
                {
                    textBox1.AppendText($"{Id}, ");
                }

                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.TrimEnd(',', ' ');
                }                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void AcceptEditOperatorButton_Click(object sender, EventArgs e)
        {
            var newIds = textBox1.Text.Split(',').Select(id => id.Trim()).ToList();

            _operatorService.EditOperator(opToEdit, newIds);

            this.DialogResult = DialogResult.OK;

        }


    }
}
