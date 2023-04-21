using LiskovSubstitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class User : UsersRole, IUser
    {
        public bool RoleChecking()
        {
            var role = CheckUser(new Guid());

            if (role == Guid.Empty) return false;
            
            return true;
        }

        public string ReadFromFile(string filename)
        {
            if (RoleChecking() != true) return "Error";

            Console.WriteLine("pass");

            return "";
        }

        public void DownloadFile(string filename) 
        {
            if (RoleChecking() != true) return;

            Console.WriteLine("pass");
        }

        public void CopyFile(string filename)
        {
            if (RoleChecking() != true) return;

            Console.WriteLine("pass");
        }

        public void CheckFile(string filename)
        {
            if (RoleChecking() != true) return;

            Console.WriteLine("pass");
        }
    }
}
