using BusinessLogic;
using DataAccessLayer;
using Model;

namespace WinFormView
{
    public partial class MainForm : Form
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                  "AttachDbFilename=C:\\Users\\Plotnik\\source\\repos\\DecanatPRO\\DataAccessLayer\\Database.mdf;" +
                                  "Integrated Security=True";

        Logic logic = new Logic(new EntityStudentRepository(new DataContext()));

        //Logic logic = new Logic(new StudentDapperRepository(connectionString));

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
                    string? name = addStudentForm.StudentName;
                    string? speciality = addStudentForm.Speciality;
                    string? group = addStudentForm.Group;

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

            int id = Convert.ToInt32(row.Cells["Id"].Value?.ToString());

            logic.DeleteStudent(id);

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

        private void StudentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
