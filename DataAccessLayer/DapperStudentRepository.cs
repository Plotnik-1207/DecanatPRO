using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccessLayer
{
    public class StudentDapperRepository : IRepository<Student>
    {
        private readonly string _connectionString;

        public StudentDapperRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Добавить студента в базу
        /// </summary>
        /// <param name="item">Студент для добавления</param>
        public void Create(Student item)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Execute(
                "INSERT INTO Students (Name, Speciality, [Group]) VALUES (@Name, @Speciality, @Group)",
                item);
        }

        /// <summary>
        /// Получить список студентов из базы
        /// </summary>
        public IEnumerable<Student> ReadAll()
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<Student>("SELECT * FROM Students");
        }

        /// <summary>
        /// Найти студента в базе по id
        /// </summary>
        /// <param name="id">Id студента для нахождения</param>
        public Student ReadById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.QueryFirstOrDefault<Student>(
                "SELECT * FROM Students WHERE Id = @Id", new { Id = id });
        }

        /// <summary>
        /// Удалить студента из базы
        /// </summary>
        /// <param name="id">Id студента для удаления</param>
        public void Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Execute("DELETE FROM Students WHERE Id = @Id", new { Id = id });
        }
    }
}
