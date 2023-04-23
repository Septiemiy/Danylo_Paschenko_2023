using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class RemoveDirs
    {
        public static void RemoveDir(string dirPath)
        {
            if (Directory.Exists(dirPath))
            {
                Directory.Delete(dirPath, true);

                UserInterface.SucceedMessage();
            }
            else
            {
                Console.WriteLine("\n---Error: Directory with this name don`t exists---");
            }
        }
    }
}
