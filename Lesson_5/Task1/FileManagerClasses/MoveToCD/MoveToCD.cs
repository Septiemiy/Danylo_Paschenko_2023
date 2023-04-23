using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MoveToCD
    {
        public static void СheckDir(string path)
        {
            var dir = path;

            if (Directory.Exists(dir))
            {
                SetCurrentDirectory(dir);   
            }
            else
            {
                Console.WriteLine("\n---Erorr: That`s directory doesn`t exists---");
            }
        }
        private static void SetCurrentDirectory(string dir)
        {
            Directory.SetCurrentDirectory(dir);
        }

        public static void GoBackDirectory()
        {
            Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
        }
    }
}