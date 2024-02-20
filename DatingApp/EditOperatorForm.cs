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
        private Operator opToEdit { get; set; }

        private List<Operator> operators;

        public EditOperatorForm(Operator opToEdit, List<Operator> operators)
        {
            if (opToEdit != null)
            {
                InitializeComponent();
                this.operators = operators;
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

            opToEdit.Ids.Clear();

            foreach (var id in newIds)
            {
                opToEdit.DeleteExistIds(id, operators);
            }

            opToEdit.Ids = newIds;

            string json = JsonConvert.SerializeObject(operators);

            File.WriteAllText("operators.json", json);

            this.DialogResult = DialogResult.OK;

        }


    }
}
