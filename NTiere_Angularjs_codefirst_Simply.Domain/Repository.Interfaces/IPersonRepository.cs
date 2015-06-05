using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTiere_Angularjs_codefirst_Simply.Domain.Models;
namespace NTiere_Angularjs_codefirst_Simply.Domain.Repository.Interfaces
{
   
    public interface IPersonRepository
    {
        void Add(Person person);
        void Update(Person person);
        void Delete(int id);
        ICollection<Person> Persons();
    }
}
