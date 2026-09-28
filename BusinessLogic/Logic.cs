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

        /// <summary>
        /// Получить список студентов
        /// </summary>
        public IReadOnlyList<Student> GetStudents()
        {
            return _repository.ReadAll().ToList();
        }

        /// <summary>
        /// Получить распределение студентов по специальностям
        /// </summary>
        public Dictionary<string, int> GetSpecialityDistribution()
        {
            var students = _repository.ReadAll().ToList();
            var specialities = students.Select(s => s.Speciality).Distinct();

            return specialities.ToDictionary(
                                            speciality => speciality,
                                            speciality => students.Count(s => s.Speciality == speciality));
        }

        /// <summary>
        /// Добавить студента
        /// </summary>
        public void AddStudent(string? name, string? speciality, string? group)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(speciality) || string.IsNullOrEmpty(group))
                return;

            _repository.Create(new Student { Name = name, Speciality = speciality, Group = group });
        }

        /// <summary>
        /// Удалить студента
        /// </summary>
        public void DeleteStudent(int id)
        {
            _repository.Delete(id);
        }
    }
}
