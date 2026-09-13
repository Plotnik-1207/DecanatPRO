namespace WinFormView
{
    partial class AddStudentForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxSpeciality = new TextBox();
            textBoxGroup = new TextBox();
            AddStudentButton = new Button();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxName, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxSpeciality, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxGroup, 0, 5);
            tableLayoutPanel1.Controls.Add(AddStudentButton, 0, 6);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(472, 256);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите имя студента";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(237, 20);
            label2.TabIndex = 1;
            label2.Text = "Введите специальность студента";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(3, 39);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(466, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxSpeciality
            // 
            textBoxSpeciality.Location = new Point(3, 111);
            textBoxSpeciality.Name = "textBoxSpeciality";
            textBoxSpeciality.Size = new Size(466, 27);
            textBoxSpeciality.TabIndex = 4;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(3, 183);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(466, 27);
            textBoxGroup.TabIndex = 5;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Anchor = AnchorStyles.Left;
            AddStudentButton.Location = new Point(3, 221);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(160, 29);
            AddStudentButton.TabIndex = 6;
            AddStudentButton.Text = "Добавить студента";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 152);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 2;
            label3.Text = "Введите группу студента";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 281);
            Controls.Add(tableLayoutPanel1);
            Name = "AddStudentForm";
            Text = "AddStudent";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxSpeciality;
        private TextBox textBoxGroup;
        private Button AddStudentButton;
    }
}