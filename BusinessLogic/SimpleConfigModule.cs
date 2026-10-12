using DataAccessLayer;
using Model;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {
            /*
            Bind<IRepository<Student>>()
                .To<EntityStudentRepository>()
                .InSingletonScope();
            */
            
            Bind<IRepository<Student>>()
            .To<StudentDapperRepository>()
            .InSingletonScope()
            .WithConstructorArgument("connectionString", "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            "AttachDbFilename=C:\\Users\\Plotnik\\source\\repos\\DecanatPRO\\DataAccessLayer\\Database.mdf;" +
            "Integrated Security=True");
            
        }
    }
}
