using DataAccessLayer;
using Model;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class Logic
    {
        private readonly IRepository<Student> _repository;

        public Logic(IRepository<Student> repository)
        {
            _repository = repository;
        }


        public IReadOnlyList<Student> GetStudents()
        {
            return _repository.ReadAll().ToList();
        }

        public Dictionary<string, int> GetSpecialityDistribution()
        {
            var students = _repository.ReadAll().ToList();
            var specialities = students.Select(s => s.Speciality).Distinct();

            return specialities.ToDictionary(
                                            speciality => speciality,
                                            speciality => students.Count(s => s.Speciality == speciality));
        }

        public void AddStudent(string? name, string? speciality, string? group)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(speciality) || string.IsNullOrEmpty(group))
                return;

            _repository.Create(new Student { Name = name, Speciality = speciality, Group = group });
        }

<<<<<<< Updated upstream
        public void DeleteStudent(int id)
        {
            _repository.Delete(id);
=======
        public void DeleteStudent(string? name, string? speciality, string? group)
        {
            if (name == null || speciality == null || group == null || name == "" || speciality == "" || group == "")
                return;

            var studentToRemove = students.Find(s => s.Name == name &&
                                                s.Speciality == speciality &&
                                                s.Group == group);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
            }
>>>>>>> Stashed changes
        }
    }
}
