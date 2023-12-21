using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class Booking
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string Client { get; set; } = default!;
        public int CountOfPeople { get; set; }
        public int RoomNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public bool Arrived { get; set; }


    }
}
