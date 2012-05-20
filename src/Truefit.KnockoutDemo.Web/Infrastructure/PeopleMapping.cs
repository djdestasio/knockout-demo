using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Truefit.KnockoutDemo.Domain.Entities;
using Truefit.KnockoutDemo.Web.Models;

namespace Truefit.KnockoutDemo.Web.Infrastructure
{
    public static class PeopleMapping
    {
        public static void CreateMaps()
        {
            Mapper.CreateMap<Person, PersonModel>();
            Mapper.CreateMap<PersonModel, Person>();
        }
    }
}