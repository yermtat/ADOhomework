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
            ReadButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            DataTablesBox = new ComboBox();
            ButtonPanel = new Panel();
            DataTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataTable).BeginInit();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DataTablePanel
            // 
            DataTablePanel.Controls.Add(DataTable);
            DataTablePanel.Dock = DockStyle.Bottom;
            DataTablePanel.Location = new Point(0, 70);
            DataTablePanel.Name = "DataTablePanel";
            DataTablePanel.Size = new Size(1009, 532);
            DataTablePanel.TabIndex = 0;
            // 
            // DataTable
            // 
            DataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataTable.Dock = DockStyle.Fill;
            DataTable.Location = new Point(0, 0);
            DataTable.Name = "DataTable";
            DataTable.Size = new Size(1009, 532);
            DataTable.TabIndex = 0;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(12, 12);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(89, 29);
            ReadButton.TabIndex = 1;
            ReadButton.Text = "Read";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(107, 12);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(89, 29);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(202, 12);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(89, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DataTablesBox
            // 
            DataTablesBox.FormattingEnabled = true;
            DataTablesBox.Location = new Point(339, 16);
            DataTablesBox.Name = "DataTablesBox";
            DataTablesBox.Size = new Size(335, 23);
            DataTablesBox.TabIndex = 10;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(DataTablesBox);
            ButtonPanel.Controls.Add(DeleteButton);
            ButtonPanel.Controls.Add(UpdateButton);
            ButtonPanel.Controls.Add(ReadButton);
            ButtonPanel.Dock = DockStyle.Top;
            ButtonPanel.Location = new Point(0, 0);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(1009, 64);
            ButtonPanel.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel DataTablePanel;
        private DataGridView DataTable;
        private Button ReadButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private ComboBox DataTablesBox;
        private Panel ButtonPanel;
    }
}
