namespace homework02_Crud
{
    partial class Form1
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
            DataTablePanel = new Panel();
            DataTable = new DataGridView();
            ButtonPanel = new Panel();
            SalaryLabel = new Label();
            SalaryTextBox = new TextBox();
            SurnameLabel = new Label();
            SurnameTextBox = new TextBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            DeleteButton = new Button();
            UpdateButton = new Button();
            ReadButton = new Button();
            CreateButton = new Button();
            DataTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataTable).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DataTablePanel
            // 
            DataTablePanel.Controls.Add(DataTable);
            DataTablePanel.Dock = DockStyle.Bottom;
            DataTablePanel.Location = new Point(0, 140);
            DataTablePanel.Name = "DataTablePanel";
            DataTablePanel.Size = new Size(1009, 462);
            DataTablePanel.TabIndex = 0;
            // 
            // DataTable
            // 
            DataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTable.Dock = DockStyle.Fill;
            DataTable.Location = new Point(0, 0);
            DataTable.Name = "DataTable";
            DataTable.Size = new Size(1009, 462);
            DataTable.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(SalaryLabel);
            ButtonPanel.Controls.Add(SalaryTextBox);
            ButtonPanel.Controls.Add(SurnameLabel);
            ButtonPanel.Controls.Add(SurnameTextBox);
            ButtonPanel.Controls.Add(NameLabel);
            ButtonPanel.Controls.Add(NameTextBox);
            ButtonPanel.Controls.Add(DeleteButton);
            ButtonPanel.Controls.Add(UpdateButton);
            ButtonPanel.Controls.Add(ReadButton);
            ButtonPanel.Controls.Add(CreateButton);
            ButtonPanel.Dock = DockStyle.Top;
            ButtonPanel.Location = new Point(0, 0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(1009, 134);
            ButtonPanel.TabIndex = 1;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(360, 74);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(38, 15);
            SalaryLabel.TabIndex = 9;
            SalaryLabel.Text = "Salary";
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Location = new Point(360, 92);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(158, 23);
            SalaryTextBox.TabIndex = 8;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(186, 74);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(54, 15);
            SurnameLabel.TabIndex = 7;
            SurnameLabel.Text = "Surname";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(186, 92);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(158, 23);
            SurnameTextBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 74);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 92);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(158, 23);
            NameTextBox.TabIndex = 4;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(297, 12);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(89, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(202, 12);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(89, 29);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(107, 12);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(89, 29);
            ReadButton.TabIndex = 1;
            ReadButton.Text = "Read";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(12, 12);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(89, 29);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 602);
            Controls.Add(ButtonPanel);
            Controls.Add(DataTablePanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            DataTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataTable).EndInit();
            ButtonPanel.ResumeLayout(false);
            ButtonPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel DataTablePanel;
        private Panel ButtonPanel;
        private Button CreateButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button ReadButton;
        private DataGridView DataTable;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Label SalaryLabel;
        private TextBox SalaryTextBox;
        private Label SurnameLabel;
        private TextBox SurnameTextBox;
    }
}
