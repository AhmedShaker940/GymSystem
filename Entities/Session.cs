namespace MVC02.Entities
{
    public class Session : BaseEntity
    {
        public string Description { get; set; } = default!; // Required
        public int Capacity { get; set; } = default!; // Required
        public DateTime StartDate { get; set; } = default!; // Required
        public DateTime EndDate { get; set; } = default!; // Required
        public int TrainerId { get; set; } //FK
        public Trainer Trainer { get; set; } = default!; // Required

    }
}
