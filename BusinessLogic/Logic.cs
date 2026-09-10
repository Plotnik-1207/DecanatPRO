using Model;

namespace BusinessLogic
{
    public class Logic
    {
        private List<Student> students = new List<Student>();

        private List<string> specialities = new List<string>();

        public IReadOnlyList<Student> GetStudents()
        {
            return students.ToList();
        }

        public Dictionary<string, int> GetSpecialityDistribution()
        {
            Dictionary<string, int> specialityDistribution = new Dictionary<string, int>();
            foreach (var item in specialities)
            {
                specialityDistribution[item] = students.Count(s => s.Speciality == item);
            }
            return specialityDistribution;
        }

        public void AddStudent(string? name, string? speciality, string? group)
        {
            if (name == null || speciality == null || group == null || name == "" || speciality == "" || group == "")
                return;
            Student newStudent = new Student { Name = name, Speciality = speciality, Group = group };
            students.Add(newStudent);
            if (!specialities.Contains(speciality))
            {
                specialities.Add(speciality);
            }
        }

        public void DeleteStudent(string name, string speciality, string group)
        {
            var studentToRemove = students.Find(s => s.Name == name &&
                                                s.Speciality == speciality &&
                                                s.Group == group);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
            }
        }
    }
}
