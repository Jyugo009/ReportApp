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
    public partial class AddOperatorForm : Form
    {
        private List<Operator> operators;


        public AddOperatorForm(List<Operator> operators)
        {
            InitializeComponent();
            this.operators = operators;
        }

        private void AcceptAddOperatorButton_Click(object sender, EventArgs e)
        {
            Operator newOp = new Operator();
            newOp.Name = textBox1.Text;
            newOp.Ids = textBox2.Text.Split(',').Select(id => id.Trim()).ToList();

            foreach (var id in newOp.Ids)
            {
                newOp.DeleteExistIds(id, operators);
            }
                 

            operators.Add(newOp);
            this.DialogResult = DialogResult.OK;
        }        

    }
}
