namespace WinFormView
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
            StudentDataGrid = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            SpecialityColumn = new DataGridViewTextBoxColumn();
            GroupColumn = new DataGridViewTextBoxColumn();
            AddStudentButton = new Button();
            DeleteStudentButton = new Button();
            ShowSpecialityDistributionButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)StudentDataGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // StudentDataGrid
            // 
            StudentDataGrid.AllowUserToAddRows = false;
            StudentDataGrid.AllowUserToDeleteRows = false;
            StudentDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            StudentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataGrid.Columns.AddRange(new DataGridViewColumn[] { NameColumn, SpecialityColumn, GroupColumn });
            StudentDataGrid.Location = new Point(12, 12);
            StudentDataGrid.MultiSelect = false;
            StudentDataGrid.Name = "StudentDataGrid";
            StudentDataGrid.ReadOnly = true;
            StudentDataGrid.RowHeadersWidth = 51;
            StudentDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentDataGrid.Size = new Size(707, 400);
            StudentDataGrid.TabIndex = 0;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "ФИО";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // SpecialityColumn
            // 
            SpecialityColumn.DataPropertyName = "Speciality";
            SpecialityColumn.HeaderText = "Специальность";
            SpecialityColumn.MinimumWidth = 6;
            SpecialityColumn.Name = "SpecialityColumn";
            SpecialityColumn.ReadOnly = true;
            // 
            // GroupColumn
            // 
            GroupColumn.DataPropertyName = "Group";
            GroupColumn.HeaderText = "Группа";
            GroupColumn.MinimumWidth = 6;
            GroupColumn.Name = "GroupColumn";
            GroupColumn.ReadOnly = true;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(3, 3);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(147, 29);
            AddStudentButton.TabIndex = 1;
            AddStudentButton.Text = "Добавить студента";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // DeleteStudentButton
            // 
            DeleteStudentButton.Location = new Point(156, 3);
            DeleteStudentButton.Name = "DeleteStudentButton";
            DeleteStudentButton.Size = new Size(139, 29);
            DeleteStudentButton.TabIndex = 2;
            DeleteStudentButton.Text = "Удалить студента";
            DeleteStudentButton.UseVisualStyleBackColor = true;
            DeleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // ShowSpecialityDistributionButton
            // 
            ShowSpecialityDistributionButton.Location = new Point(301, 3);
            ShowSpecialityDistributionButton.Name = "ShowSpecialityDistributionButton";
            ShowSpecialityDistributionButton.Size = new Size(403, 29);
            ShowSpecialityDistributionButton.TabIndex = 4;
            ShowSpecialityDistributionButton.Text = "Вывести распределение студентов по специальностям";
            ShowSpecialityDistributionButton.UseVisualStyleBackColor = true;
            ShowSpecialityDistributionButton.Click += ShowSpecialityDistributionButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(AddStudentButton, 0, 0);
            tableLayoutPanel1.Controls.Add(DeleteStudentButton, 1, 0);
            tableLayoutPanel1.Controls.Add(ShowSpecialityDistributionButton, 3, 0);
            tableLayoutPanel1.Location = new Point(12, 418);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(707, 35);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(732, 478);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(StudentDataGrid);
            Name = "MainForm";
            Padding = new Padding(10);
            Text = "DecanatPRO";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentDataGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentDataGrid;
        private Button AddStudentButton;
        private Button DeleteStudentButton;
        private Button ShowSpecialityDistributionButton;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn SpecialityColumn;
        private DataGridViewTextBoxColumn GroupColumn;
    }
}
