using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class Archive
    {
        public int IdRegistration { get; set; }
        public int CountOfPeople { get; set; }
        public string Surname { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string MiddleName { get; set; } = default!;
        public string ClientPassportNumber { get; set; } = default!;
        public DateTime Birthday { get; set; }
        public string Gender { get; set; } = default!;
        public string ClientAddress { get; set; } = default!;
        public string ClientPhoneNumber { get; set; } = default!;
        public int RoomNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int SumOfLiving { get; set; }
        public int SumOfServices { get; set; }
        public int TotalSum { get; set; }
    }
}
