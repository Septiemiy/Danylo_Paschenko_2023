using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MoveFiles
    {
        public static void MoveFile(string filePath, string newPath)
        {
            if (CheckFile(filePath) == false) return;
            if (CheckNewPath(newPath) == false) return;

            var file = new FileInfo(filePath);
            newPath = Path.Combine(newPath, file.Name);

            file.MoveTo(newPath);

            UserInterface.SucceedMessage();
        }

        private static bool CheckFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("\n---Error: File with this name don't exists---");
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
