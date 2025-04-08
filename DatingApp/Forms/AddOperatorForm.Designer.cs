namespace ReportApp
{
    partial class AddOperatorForm
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
            AddOperatorButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // AddOperatorButton
            // 
            AddOperatorButton.Location = new Point(411, 246);
            AddOperatorButton.Name = "AddOperatorButton";
            AddOperatorButton.Size = new Size(94, 29);
            AddOperatorButton.TabIndex = 0;
            AddOperatorButton.Text = "Добавить";
            AddOperatorButton.UseVisualStyleBackColor = true;
            AddOperatorButton.Click += AcceptAddOperatorButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 81);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(493, 151);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 3;
            label1.Text = "Имя Нового Оператора";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(276, 20);
            label2.TabIndex = 4;
            label2.Text = "ID Нового Оператора (через запятую)";
            // 
            // AddOperatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 287);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(AddOperatorButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AddOperatorForm";
            Text = "Новый Оператор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddOperatorButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}