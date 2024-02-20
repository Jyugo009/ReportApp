namespace DatingApp
{
    partial class ReportForm
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
            listBox1 = new ListBox();
            CopyAndDoneButton = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(17, 11);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(582, 344);
            listBox1.TabIndex = 0;
            // 
            // CopyAndDoneButton
            // 
            CopyAndDoneButton.Location = new Point(334, 380);
            CopyAndDoneButton.Name = "CopyAndDoneButton";
            CopyAndDoneButton.Size = new Size(265, 29);
            CopyAndDoneButton.TabIndex = 1;
            CopyAndDoneButton.Text = "Скопировать и Завершить";
            CopyAndDoneButton.UseVisualStyleBackColor = true;
            CopyAndDoneButton.Click += CopyAndDoneButton_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 421);
            Controls.Add(CopyAndDoneButton);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "ReportForm";
            Text = "Отчет";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button CopyAndDoneButton;
    }
}