using System.ComponentModel.DataAnnotations;

namespace Truefit.KnockoutDemo.Domain.Entities
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string firstName, string lastName, string position = "Software Engineer")
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(75)]
        public string LastName { get; set; }
        [StringLength(75)]
        public string Position { get; set; }
    }
}