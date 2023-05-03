using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class UserInterface
    {
        public static void UserMenu()
        {
            Console.WriteLine(
                "\n1 - Addition (+)\n" +
                "2 - Subtraction (-)\n" +
                "3 - Multiplication (*)\n" +
                "4 - Division (/)\n" +
                "5 - Exponentiation (^)\n" +
                "6 - Square root (sqrt)\n" +
                "7 - Quit program (q)\n");
        }

        public static void HelloMessage() => Console.WriteLine("Hello, it is a console calculator.\nTo use its functions, entire: +, -, *, /, ^, sqrt");
        
        public static string GetUserChoice()
        {
            var userChoice = Console.ReadLine();
            return userChoice;
        }

        public static double GetNumber()
        {
            try
            {
                var number = double.Parse(Console.ReadLine());
                return number;
            }
            catch
            {
                OutputResultOrError.InvalidNumberError();
                return default;
            }
        }

        public static void EntireOperations() => Console.Write("\nEntire functions identifier what you want: ");

        public static void EntireNumberOne() => Console.Write("\nEntire number one: ");

        public static void EntireNumberTwo() => Console.Write("\nEntire number two: ");

        public static void EntireNumberForExponentiation() => Console.Write("\nEntire number for exponentiation: ");

        public static void EntireExponentiationPower() => Console.Write("\nEntire exponentiation power: ");

        public static void EntireNumberForSquareRoot() => Console.Write("\nEntire number for square root: ");

        public static void EntireSquareRootExponent() => Console.Write("\nEntire square root exponent: ");

        public static void AddFunctionsToEvent()
        {
            OutputResultOrError.NotifyResult += displayGreenMessage;
            OutputResultOrError.NotifyError += displayRedMessage;
        }

        private static void displayGreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void displayRedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static double GetNumberOne()
        {
            EntireNumberOne();
            var number = GetNumber();
            if (number == default) return default;
            return number;
        }

        public static double GetNumberTwo()
        {
            EntireNumberTwo();
            var number = GetNumber();
            if (number == default) return default;
            return number;
        }

        public static double GetSquareRootNumber() 
        {
            EntireNumberForSquareRoot();
            var number = GetNumber();
            if (number == default) return default;
            return number;
        }

        public static double GetSquareRootExponent()
        {
            EntireSquareRootExponent();
            var number = GetNumber();
            if (number == default) return default;
            return number;
        }

        public static double GetExponentiationNumber()
        {
            EntireNumberForExponentiation();
            var number =GetNumber();
            if (number == default) return default;
            return number;
        }

        public static double GetExponentiationPowerNumber()
        {
            EntireExponentiationPower();
            var number = GetNumber();
            if (number == default) return default;
            return number;
        }
    }
}
