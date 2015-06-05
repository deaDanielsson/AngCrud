using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace NTiere_Angularjs_codefirst_Simply.Data
{
    public class BaseContext<TContext>:DbContext where TContext:DbContext       
    {
        static BaseContext()
        {
            //If model Changes Drop and Create Database again
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TContext>());
        }
        //Setting connection string
        public BaseContext()
            : base(@"Server=.\sqlexpress;database=PersonDb;integrated security=true;")
        { }
    }
}
