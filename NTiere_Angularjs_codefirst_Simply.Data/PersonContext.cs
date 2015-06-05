using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTiere_Angularjs_codefirst_Simply.Domain.Models;
using System.Data.Entity;
namespace NTiere_Angularjs_codefirst_Simply.Data
{
    public class PersonContext:BaseContext<PersonContext>
    {
        public DbSet<Person> Pesons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Initialize Person Configuration
            modelBuilder.Configurations.Add(new ModelConfig.PersonConfiguration());
        }
       
    }
}
