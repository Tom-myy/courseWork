using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    internal class UsersTable
    {
        public int IdUser { get; set; }
        public string LoginUser { get; set; } = default!;
        public string PasswordUser { get; set; } = default!;
        public bool IsAdmin { get; set; }
    }
}
