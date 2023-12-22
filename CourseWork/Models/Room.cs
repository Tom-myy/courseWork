using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public int Floor {get;set;}
        public string TypeName {get;set;} = default!;
        // IsActive - typo
        public bool IsActiv {get;set;}
    }
}
