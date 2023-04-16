using Open_Closed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class MagicClass
    {
        public virtual void CountYourMagic(int magic)
        {
            Console.WriteLine("I understand you...");
        }

        public void ChooseMagic(List<MagicClass> magicList, int magic)
        {
            for (int i = 0; i < magicList.Count(); i++)
            {
                magicList[i].CountYourMagic(magic);
            }
        }
    }

    public class FireMagic : MagicClass
    {
        public override void CountYourMagic(int magic)
        {
            if (magic == 150)
            {
                Console.WriteLine("Wow, your magic is fire magic!");
                base.CountYourMagic(magic);
                return;
            }
        }
    }

    public class WaterMagic : MagicClass
    {
        public override void CountYourMagic(int magic)
        {
            if (magic == 50000000)
            {
                Console.WriteLine("Incredible! You have 50 millions of power! It's water magic!");
                base.CountYourMagic(magic);
                return;
            }
        }
    }
}