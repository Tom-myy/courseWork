using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class Typee
    {
        public string TypeName { get; set; } = default!;
        public int CountOfRoomsInType { get; set; }
        public int CountOfPlacesInType { get; set; }
        public string TypeDescription { get; set; } = default!;
        public int TypePrice { get; set; }
        public int CountOfRoomInHotel { get; set; }
    }
}
