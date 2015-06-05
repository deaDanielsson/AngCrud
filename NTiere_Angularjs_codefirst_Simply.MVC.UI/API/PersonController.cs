using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NTiere_Angularjs_codefirst_Simply.Service;
using NTiere_Angularjs_codefirst_Simply.Domain.Models;
namespace NTiere_Angularjs_codefirst_Simply.MVC.UI.API
{
    public class PersonController : ApiController
    {
        // GET api/<controller>
        PersonCRUDService _svc = new PersonCRUDService();
        public IEnumerable<Person> Get()
        {
            return _svc.Persons;
        }

     

        // POST api/<controller>
        [HttpPost]
        public Person Post(Person person)
        {
            _svc.Add(person);
            return person;
        }

        // PUT api/<controller>/5
        [HttpPut]
        public Person Put(Person person)
        {
            _svc.update(person);
            return person;
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public void Delete(int id)
        {
            _svc.Delete(id);
        }
    }
}