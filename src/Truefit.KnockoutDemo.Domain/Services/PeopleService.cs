using System.Collections.Generic;
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
    }
}