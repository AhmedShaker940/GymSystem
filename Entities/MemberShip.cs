using System.ComponentModel.DataAnnotations.Schema;

namespace MVC02.Entities
{
    public class MemberShip : BaseEntity
    {
        public int MemberId { get; set; } // FK
        public Member Member { get; set; }
        public int PlanId { get; set; } // FK
        public Plan Plan { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Column Status // Not In DataBase

        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "Upcoming"
                                : EndDate > DateTime.Now ? "Active"
                                : "Expired";
    }
}
