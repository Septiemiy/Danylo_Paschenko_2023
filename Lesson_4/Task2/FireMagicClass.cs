using Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class FireMagic : MagicClass
    {
        public override void CountYourMagic(int magic)
        {
            if (magic == 150)
            {
                Console.WriteLine("Wow, your magic is fire magic!");
                //base.CountYourMagic(magic);
                return;
            }
        }
    }
}