using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class CheckAndShowContent
    {
        public virtual void CheckContent(List<string> content)
        {
            if (content.Count == 0)
            {
                Console.WriteLine($"\n---Error: There are no content---");
            }
            else
            {
                ShowContent(content);
            }
        }
        private void ShowContent(List<string> content)
        {
            int i = 1;
            foreach (var item in content) 
            {
                Console.WriteLine($"\n[{i++}] - {item.Split('\\').Last()}");
            }
        }
    }
}
