using MVC02.Entities.Enums;
using System.Reflection.Metadata.Ecma335;

namespace MVC02.Entities
{
    // Not In DataBase
    public class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!; // Required
        public string Email { get; set; } = default!; // Required
        public string Phone { get; set; } = default!; // Required
        public DateOnly DateOfBirth { get; set; } = default!; // Required
        public Gender Gender { get; set; } = default!; // Required 
        public Address Address { get; set; } = default!; //Street Country BuildingNumber
    }
}
