using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Truefit.KnockoutDemo.Domain.Entities;

namespace Truefit.KnockoutDemo.Domain.Services
{
    public class TeamService : ServiceBase, ITeamService
    {
        [Inject]
        public TeamService(DemoContext context) : base(context)
        {
        }

        public IEnumerable<Team> All
        {
            get { return Context.Teams.OrderBy(x => x.Name); }
        } 
    }
}
