using Model;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DataContext() : base("Data Source=(LocalDB)\\" +
            "MSSQLLocalDB;AttachDbFilename=C:\\Users\\Plotnik\\source\\repos\\DecanatPRO" +
            "\\DataAccessLayer\\Database.mdf;Integrated Security=True")
        { }
    }
}
