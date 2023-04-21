using LiskovSubstitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Owner : Administrator, IOwner
    {
        public void DeleteFile(string filename)
        {
            if (RoleChecking() != true) return;

            Console.WriteLine("pass");
        }
    }
}
