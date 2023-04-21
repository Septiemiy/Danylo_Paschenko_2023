using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Administrator : User, IAdministrator
    {
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
    }
}
