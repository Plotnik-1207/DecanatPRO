using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EntityStudentRepository : IRepository<Student>
    {
        private readonly DataContext _context;

        public EntityStudentRepository(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Добавить студента в базу
        /// </summary>
        /// <param name="item">Студент для добавления</param>
        public void Create(Student item)
        {
            _context.Students.Add(item);
            _context.SaveChanges();
        }

        /// <summary>
        /// Получить список студентов из базы
        /// </summary>
        public IEnumerable<Student> ReadAll()
        {
            return _context.Students.ToList();
        }

        /// <summary>
        /// Найти студента в базе по id
        /// </summary>
        /// <param name="id">Id студента для нахождения</param>
        public Student ReadById(int id)
        {
            return _context.Students.Find(id);
        }

        /// <summary>
        /// Удалить студента из базы
        /// </summary>
        /// <param name="id">Id студента для удаления</param>
        public void Delete(int id)
        {
            var entity = _context.Students.Find(id);
            if (entity != null)
            {
                _context.Students.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
