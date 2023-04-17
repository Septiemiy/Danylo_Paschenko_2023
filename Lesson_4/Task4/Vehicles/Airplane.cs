using LiskovSubstitution.Interfaces;
using LiskovSubstitution.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Airplane : Vehicle, IFlyable
    {
        public override void StartEngine()
        {
            Console.WriteLine("Airplane:");
            base.StartEngine();
        }

        public void Fly()
        {
            Console.WriteLine("Airplane flying");
        }
    }
}
