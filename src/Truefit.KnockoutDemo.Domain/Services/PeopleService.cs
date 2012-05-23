using System.Collections.Generic;
using System.Data;
using System.Linq;
using Truefit.KnockoutDemo.Domain.Entities;

namespace Truefit.KnockoutDemo.Domain.Services
{
    public class PeopleService : ServiceBase, IPeopleService
    {
        public PeopleService(DemoContext context) : base (context)
        {
        }
        
        public IEnumerable<Person> All
        {
            get { return Context.People.OrderBy(x => x.FirstName).ToList(); }
        } 

        public void InsertOrUpdate(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                if (person.Id > 0)
                {
                    Context.People.Attach(person);
                    Context.Entry(person).State = EntityState.Modified;
                }
                else
                {
                    Context.People.Add(person);
                }

                Context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var person = Context.People.Find(id);
            if(person != null)
            {
                Context.People.Remove(person);
                Context.SaveChanges();
            }
        }
    }
}