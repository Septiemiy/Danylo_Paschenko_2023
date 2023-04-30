using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ShowDirsClass : CheckAndShowContent
    {
        public void ShowDirs()
        {
            var dir = Directory.GetCurrentDirectory();

            var dirs = new List<string>();
            dirs.AddRange(Directory.GetDirectories(dir));

            CheckContent(dirs);        
        }

        public override void CheckContent(List<string> content)
        {
            if (content.Count == 0)
            {
                Console.WriteLine("\n---Error: There are no dirs---");
            }
            else
            {
                base.CheckContent(content);
            }
        }
    }
}
