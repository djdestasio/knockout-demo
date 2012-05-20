using System.Collections.Generic;
using Truefit.KnockoutDemo.Domain.Entities;

namespace Truefit.KnockoutDemo.Domain.Services
{
    public interface ITeamService
    {
        IEnumerable<Team> All { get; } 
    }
}