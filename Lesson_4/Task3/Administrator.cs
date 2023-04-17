using LiskovSubstitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Administrator : User, IAdministrator, ICheckFile
    {
        public bool RoleChecking()
        {
            var role = CheckUser(new Guid());

            if (role == Guid.Empty) return false;

            return true;
        }

        public void WriteToFile(string filename)
        {
            if (RoleChecking() != true) return;

            Console.WriteLine("pass");
        }

        public void SaveToFile(string filename)
        {
            if (RoleChecking() != true) return;

            Console.WriteLine("pass");
        }

        public void GetDataFromFile(string filename)
        {
            if (RoleChecking() != true) return;

            Console.WriteLine("pass");
        }

        public void DeleteFile(string filename)
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
