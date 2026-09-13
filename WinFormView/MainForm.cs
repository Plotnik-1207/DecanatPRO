using BusinessLogic;

namespace WinFormView
{
    public partial class MainForm : Form
    {
        private Logic logic = new Logic();
        public MainForm()
        {
            InitializeComponent();

            StudentDataGrid.DataSource = logic.GetStudents();
        }

        private void RefreshStudentDataGrid()
        {
            StudentDataGrid.DataSource = null;
            StudentDataGrid.DataSource = logic.GetStudents();

            StudentDataGrid.ClearSelection();
            StudentDataGrid.CurrentCell = null;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            using (AddStudentForm addStudentForm = new AddStudentForm())
            {
                if (addStudentForm.ShowDialog() == DialogResult.OK)
                {
                    string name = addStudentForm.StudentName;
                    string speciality = addStudentForm.Speciality;
                    string group = addStudentForm.Group;

                    logic.AddStudent(name, speciality, group);

                    RefreshStudentDataGrid();
                }
            }
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите студента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DataGridViewRow row = StudentDataGrid.SelectedRows[0];

            string name = row.Cells["Name"].Value?.ToString();
            string speciality = row.Cells["Speciality"].Value?.ToString();
            string group = row.Cells["Group"].Value?.ToString();

            logic.DeleteStudent(name, speciality, group);

            RefreshStudentDataGrid();
        }

        private void ShowSpecialityDistributionButton_Click(object sender, EventArgs e)
        {
            StudentHistogramForm studentHistogramForm = new StudentHistogramForm(logic);
            studentHistogramForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
