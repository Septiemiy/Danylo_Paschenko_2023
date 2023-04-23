using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ShowFilesClass : CheckAndShowContent
    {
        public void ShowFiles()
        {
            var dir = Directory.GetCurrentDirectory();

            var files = new List<string>();
            files.AddRange(Directory.GetFiles(dir));

            CheckContent(files);
        }

        public override void CheckContent(List<string> content)
        {
            if (content.Count == 0)
            {
                Console.WriteLine("\n---Error: There are no files---");
            }
            else
            {
                base.CheckContent(content);
            }
        }
    }
}
