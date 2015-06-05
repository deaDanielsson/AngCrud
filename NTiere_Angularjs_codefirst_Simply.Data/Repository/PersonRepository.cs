using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTiere_Angularjs_codefirst_Simply.Domain.Repository.Interfaces;
namespace NTiere_Angularjs_codefirst_Simply.Data.Repository
{
    public class PersonRepository:IPersonRepository
    {
        public void Add(Domain.Models.Person person)
        {
            if(person==null)
            {
                throw new NotImplementedException("Person not intialized");
            }
            using(PersonContext ctx=new PersonContext())
            {
                ctx.Pesons.Add(person);
                ctx.SaveChanges();

            }
        }

        public void Update(Domain.Models.Person person)
        {
           
            using (PersonContext ctx = new PersonContext())
            {
                var personEntity = ctx.Pesons.SingleOrDefault(p=>p.ID==person.ID);
                if (personEntity == null)
                {
                    throw new NotImplementedException("Person not intialized");
                }
                ctx.Entry(personEntity).CurrentValues.SetValues(person);
                ctx.SaveChanges();

            }
        }

        public void Delete(int id)
        {
          
            using (PersonContext ctx = new PersonContext())
            {
                var personEntity = ctx.Pesons.SingleOrDefault(p => p.ID ==id);
                if (personEntity == null)
                {
                    throw new NotImplementedException("Person not intialized");
                }
                ctx.Pesons.Remove(personEntity);
                ctx.SaveChanges();

            }
        }

        public ICollection<Domain.Models.Person> Persons()
        {
           using(PersonContext ctx=new PersonContext())  
           {
               return ctx.Pesons.ToList();
           }
        }
    }
}
