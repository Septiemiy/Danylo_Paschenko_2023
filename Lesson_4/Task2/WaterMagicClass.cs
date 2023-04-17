using Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class WaterMagic : MagicClass
    {
        public override void CountYourMagic(int magic)
        {
            if (magic == 50000000)
            {
                Console.WriteLine("Incredible! You have 50 millions of power! It's water magic!");
                //base.CountYourMagic(magic);
                return;
            }
        }
    }
}