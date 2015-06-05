using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using NTiere_Angularjs_codefirst_Simply.Domain.Models;
namespace NTiere_Angularjs_codefirst_Simply.Data.ModelConfig
{
    public class PersonConfiguration:EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            //User defined table name
            this.ToTable("Persons");
            //Setting PK/Identity field
            Property(p=>p.ID).IsRequired();
            
        }
    }
}
