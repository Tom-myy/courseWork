﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace CourseWork.Models
{
    internal class Usage
    {
        public int Id { get; set; } 
        public int IdService { get; set; } 
        public string Service { get; set; } = default!;
        public int IdRegistration { get; set; }
        public string Client { get; set; } = default!;
        public int CountOfUsedServices { get; set; } 
        public int SumOfServices { get; set; } 
    }
}
