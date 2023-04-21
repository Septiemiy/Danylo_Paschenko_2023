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
            Console.WriteLine("Wow, your magic is fire magic!");
            return;
        }
    }
}