namespace DatingApp
{
    partial class EditOperatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            AcceptEditOperator = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 223);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AcceptEditOperator
            // 
            AcceptEditOperator.Location = new Point(411, 246);
            AcceptEditOperator.Name = "AcceptEditOperator";
            AcceptEditOperator.Size = new Size(94, 29);
            AcceptEditOperator.TabIndex = 1;
            AcceptEditOperator.Text = "Принять";
            AcceptEditOperator.UseVisualStyleBackColor = true;
            AcceptEditOperator.Click += AcceptEditOperatorButton_Click;
            // 
            // EditOperatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 287);
            Controls.Add(AcceptEditOperator);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "EditOperatorForm";
            Text = "Редактирование Оператора";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button AcceptEditOperator;
    }
}