using System.Collections.Generic;
using Truefit.KnockoutDemo.Domain.Entities;

namespace Truefit.KnockoutDemo.Domain.Services
{
    public interface IPeopleService
    {
        IEnumerable<Person> All { get; } 
    }
}