using LiskovSubstitution.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car:");
            base.StartEngine();
        }
    }
}
