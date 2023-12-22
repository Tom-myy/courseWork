using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace CourseWork.Models
{
    internal class Service
    {
        public int IdService { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public int ServicePrice { get; set; }
        // typo - IsActive
        public bool IsActiv { get; set; }
    }
}
