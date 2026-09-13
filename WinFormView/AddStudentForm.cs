using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace WinFormView
{
    public partial class AddStudentForm : Form
    {
        public string? StudentName { get; private set; }
        public string? Speciality { get; private set; }
        public string? Group { get; private set; }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxSpeciality.Text) || string.IsNullOrWhiteSpace(textBoxGroup.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                StudentName = textBoxName.Text;
                Speciality = textBoxSpeciality.Text;
                Group = textBoxGroup.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
