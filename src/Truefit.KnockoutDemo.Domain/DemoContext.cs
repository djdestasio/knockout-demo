using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Truefit.KnockoutDemo.Domain.Entities;

namespace Truefit.KnockoutDemo.Domain
{
    public class DemoContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
    }

    public class DemoInitializer : DropCreateDatabaseAlways<DemoContext>
    {
        protected override void Seed(DemoContext context)
        {
            var people = new List<Person>
                             {
                                 new Person("Dominick", "DeStasio"),
                                 new Person("Matt", "Orres"),
                                 new Person("Josh", "Gretz"),
                                 new Person("Adam", "Kirkton"),
                                 new Person("James", "Frengel"),
                                 new Person("Mike", "Frengel"),
                                 new Person("John", "Sacks"),
                                 new Person("Kurt", "Nolker"),
                                 new Person("Josh", "Gillespie"),
                                 new Person("Marcello", "Figallo", "Creative Director"),
                                 new Person("Max", "McCarty"),
                                 new Person("Michael", "Collins"),
                                 new Person("Pete", "Bruns"),
                                 new Person("Scott", "Maxwell"),
                                 new Person("John", "Romesburg"),
                                 new Person("Herb", "Weaver"),
                                 new Person("Scott", "Maxwell"),
                                 new Person("Brad", "Moeller"),
                                 new Person("Evan", "Dull")
                             };

            people.ForEach(x => context.People.Add(x));
            context.SaveChanges();
        }
    }
}
