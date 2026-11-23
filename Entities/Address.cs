namespace MVC02.Entities
{
    public class Address
    {
        public string Street { get; set; } = default!; // Required
        public string Country { get; set; } = default!; // Required
        public int BuildingNumber { get; set; }
    }
}
