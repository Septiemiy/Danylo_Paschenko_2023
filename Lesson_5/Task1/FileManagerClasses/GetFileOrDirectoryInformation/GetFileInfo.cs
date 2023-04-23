using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class GetFileInfo
    {

        private static FileInfo GetInfo(string filePath)
        {
            if (CheckFile(filePath) == false) return null;

            var fileInfo = new FileInfo(filePath);
            return fileInfo;
        }

        public static void OutputInfo(string filePath)
        {
            if (GetInfo(filePath) != null)
            {
                var fileInfo = GetInfo(filePath);
                
                Console.WriteLine(
                    $"\nName:\n\t{fileInfo.Name}\n\n" +
                    $"File length:\n\t{fileInfo.Length} bytes\n\n" +
                    $"Creation time:\n\t{fileInfo.CreationTime}\n\n" +
                    $"Last modification time:\n\t{fileInfo.LastWriteTime}\n");
            }
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
