using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class CheckUser
    {
        public string Login { get; set; } = default!;

        public bool IsAdmin { get; }

        public string Status => IsAdmin ? "Admin" : "Vip";

        public CheckUser (string login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
        public CheckUser()
        {

        }
    }
}
