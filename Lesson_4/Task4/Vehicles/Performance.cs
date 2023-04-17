using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4;

namespace LiskovSubstitution
{
    public class Perfomance
    {
        public void PerformActions()
        {
            var car = new Car();
            var motorcycle = new Motorcycle();
            var airplane = new Airplane();

            car.StartEngine();
            motorcycle.StartEngine();
            airplane.StartEngine();

            Thread.Sleep(3000);

            airplane.Fly();
        }
    }
}