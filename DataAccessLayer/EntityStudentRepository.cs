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

        public void Create(Student item)
        {
            _context.Students.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Student> ReadAll()
        {
            return _context.Students.ToList();
        }

        public Student ReadById(int id)
        {
            return _context.Students.Find(id);
        }

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
