using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    // If you have similar name as you have, for example, in SystemNamespace
    // Just make a mistake in the word is very bad approach...
    // You could rename it as RoomType or something like this
    // Frankly speaking you could just remove unused usings and name it as Type
    // And when you call this class you only need to call it by full name CourseWork.Models.Type or Models.Type
    // Or use the static using to replace the type name in file to other one
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
