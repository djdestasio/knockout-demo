namespace Truefit.KnockoutDemo.Domain.Entities
{
    public class TeamMember
    {
        public int Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual Team Team { get; set; }
    }
}