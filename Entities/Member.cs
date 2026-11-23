namespace MVC02.Entities
{
    public class Member : GymUser
    {
        public string? Photo {  get; set; } // Modification
        public ICollection<MemberShip> PlanSubscription { get; set; } = default!;
    }
}
