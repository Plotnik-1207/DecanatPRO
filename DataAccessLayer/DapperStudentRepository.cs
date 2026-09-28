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

        public void Create(Student item)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Execute(
                "INSERT INTO Students (Name, Speciality, [Group]) VALUES (@Name, @Speciality, @Group)",
                item);
        }

        public IEnumerable<Student> ReadAll()
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<Student>("SELECT * FROM Students");
        }

        public Student ReadById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.QueryFirstOrDefault<Student>(
                "SELECT * FROM Students WHERE Id = @Id", new { Id = id });
        }

        public void Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Execute("DELETE FROM Students WHERE Id = @Id", new { Id = id });
        }
    }
}
