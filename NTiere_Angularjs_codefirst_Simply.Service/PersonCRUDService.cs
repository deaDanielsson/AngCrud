using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTiere_Angularjs_codefirst_Simply.Data.Repository;
using NTiere_Angularjs_codefirst_Simply.Domain.Models;
using NTiere_Angularjs_codefirst_Simply.Domain.Repository.Interfaces;
namespace NTiere_Angularjs_codefirst_Simply.Service
{
    //Implementing facade/service pattern
    public class PersonCRUDService
    {
        IPersonRepository _repo = new PersonRepository();
        public void Add(Person person)
        {
            _repo.Add(person);
        }
        public void update(Person person)
        {
            _repo.Update(person);
        }
        public void Delete(int id)
        {
            _repo.Delete(id);
        }
        public ICollection<Person> Persons
        {
            get { return _repo.Persons(); }
        }
    }
}
