// remove usings that are not used
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

        public string Status => IsAdmin ? "Admin" : "Vip"; // Such variables are moved to constants. Because it could be repeated in many places

        public CheckUser (string login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }

        // Remove constructors that are not used
        public CheckUser()
        {

        }
    }
}
