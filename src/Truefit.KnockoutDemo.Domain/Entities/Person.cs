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

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
    }
}