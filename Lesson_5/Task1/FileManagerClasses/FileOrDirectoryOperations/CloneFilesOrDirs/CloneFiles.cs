using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class CloneFiles
    {
        public static void CloneFile(string filePath)
        {
            if (CheckFile(filePath) == false) return;

            try
            {
                File.Copy(filePath, MakeCopyFileName(filePath));

                UserInterface.SucceedMessage();
            }
            catch
            {
                Console.WriteLine("\n---Error: This file already has a copy---");
            }
        }

        private static string MakeCopyFileName(string filePath)
        {
            var fileNoExtension = Path.GetFileNameWithoutExtension(filePath);
            var fileExtension = Path.GetExtension(filePath);

            var copyFileName = fileNoExtension + "-copy" + fileExtension;

            return copyFileName;
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
    }
}
