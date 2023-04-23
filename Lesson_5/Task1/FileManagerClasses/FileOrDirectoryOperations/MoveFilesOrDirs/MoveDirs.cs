using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MoveDirs
    {
        public static void MoveDir(string dirPath, string newPath)
        {
            if (CheckDir(dirPath) == false) return;
            if (CheckNewPath(newPath) == false) return;

            var dir = new DirectoryInfo(dirPath);
            newPath = Path.Combine(newPath, dir.Name);

            dir.MoveTo(newPath);

            UserInterface.SucceedMessage();
        }

        private static bool CheckDir(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                Console.WriteLine("\n---Error: Directory with this name don't exists---");
                return false;
            }
            return true;
        }

        private static bool CheckNewPath(string newPath)
        {
            if (!Directory.Exists(newPath))
            {
                Console.WriteLine("\n---Error: This path don`t exists---");
                return false;
            }
            return true;
        }
    }
}
