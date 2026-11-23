namespace MVC02.Entities
{
    public class Plan :BaseEntity
    {
        public string Name { get; set; } = default!; // Required
        public decimal Price { get; set; }
        public string Description { get; set; } = default!; // Required
        public int DurationDays { get; set; }
        public bool IsActive { get; set; }
        public ICollection<MemberShip> MemberShip { get; set; }

    }
}
