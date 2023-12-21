using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class Busyness
    {
        public int RoomNumber { get; set; }
        public DateTime Date { get; set; }
        public int CountOfPeopleInRoom { get; set; }
        public int FreePlaces { get; set; }
    }
}
