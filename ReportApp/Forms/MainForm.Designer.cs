namespace ReportApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Browse = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            AddOperator = new Button();
            DeleteOperator = new Button();
            label1 = new Label();
            MakeReport = new Button();
            EditOperator = new Button();
            EarseListBoxButton = new Button();
            SuspendLayout();
            // 
            // Browse
            // 
            Browse.Location = new Point(592, 505);
            Browse.Name = "Browse";
            Browse.Size = new Size(197, 29);
            Browse.TabIndex = 0;
            Browse.Text = "Загрузить";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(0, 0);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(799, 484);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(821, 34);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(420, 404);
            listBox2.TabIndex = 2;
            // 
            // AddOperator
            // 
            AddOperator.Location = new Point(821, 455);
            AddOperator.Name = "AddOperator";
            AddOperator.Size = new Size(197, 29);
            AddOperator.TabIndex = 3;
            AddOperator.Text = "Добавить Оператора";
            AddOperator.UseVisualStyleBackColor = true;
            AddOperator.Click += AddOperator_Click;
            // 
            // DeleteOperator
            // 
            DeleteOperator.Location = new Point(1044, 455);
            DeleteOperator.Name = "DeleteOperator";
            DeleteOperator.Size = new Size(197, 29);
            DeleteOperator.TabIndex = 4;
            DeleteOperator.Text = "Удалить Оператора";
            DeleteOperator.UseVisualStyleBackColor = true;
            DeleteOperator.Click += DeleteOperator_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(821, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 5;
            label1.Text = "Список Операторов в Работе";
            // 
            // MakeReport
            // 
            MakeReport.Location = new Point(821, 490);
            MakeReport.Name = "MakeReport";
            MakeReport.Size = new Size(197, 29);
            MakeReport.TabIndex = 6;
            MakeReport.Text = "Сделать Отчет";
            MakeReport.UseVisualStyleBackColor = true;
            MakeReport.Click += MakeReport_Click;
            // 
            // EditOperator
            // 
            EditOperator.Location = new Point(1044, 490);
            EditOperator.Name = "EditOperator";
            EditOperator.Size = new Size(197, 29);
            EditOperator.TabIndex = 7;
            EditOperator.Text = "Изменить Оператора";
            EditOperator.UseVisualStyleBackColor = true;
            EditOperator.Click += EditOperator_Click;
            // 
            // EarseListBoxButton
            // 
            EarseListBoxButton.Location = new Point(367, 505);
            EarseListBoxButton.Name = "EarseListBoxButton";
            EarseListBoxButton.Size = new Size(197, 29);
            EarseListBoxButton.TabIndex = 8;
            EarseListBoxButton.Text = "Очистить";
            EarseListBoxButton.UseVisualStyleBackColor = true;
            EarseListBoxButton.Click += EarseListBoxButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1253, 547);
            Controls.Add(EarseListBoxButton);
            Controls.Add(EditOperator);
            Controls.Add(MakeReport);
            Controls.Add(label1);
            Controls.Add(DeleteOperator);
            Controls.Add(AddOperator);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(Browse);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Prime Alive App ver.0.83";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Browse;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button AddOperator;
        private Button DeleteOperator;
        private Label label1;
        private Button MakeReport;
        private Button EditOperator;
        private Button EarseListBoxButton;
    }
}