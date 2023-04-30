using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class RemoveFilesAsync
    {
        async public static Task RemoveFileAsync(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);

                UserInterface.SucceedMessage();
            }
            else
            {
                Console.WriteLine("\n---Error: File with this name don`t exists---");
            }
        }
    }
}
