using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class CalculatorOperations
    {
        public static double Addition(double x, double y) => x + y;

        public static double Subtraction(double x, double y) => x - y;

        public static double Multiplication(double x, double y) => x * y;

        public static double Division(double x, double y) => x / y;

        public static double Exponentiation(double x, double y) => Math.Pow(x, y);

        public static double SquareRoot(double x, double y) => Math.Pow(x, 1/y);
    }
}
