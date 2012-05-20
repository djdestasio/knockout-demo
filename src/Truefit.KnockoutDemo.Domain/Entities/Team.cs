using System.Collections.Generic;

namespace Truefit.KnockoutDemo.Domain.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string LogoUrl { get; set; }
        public string Manager { get; set; }
        public virtual IEnumerable<TeamMember> Members { get; set; }
    }
}