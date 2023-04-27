using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Calculator
    {
        delegate double Operation(double x, double y);
        delegate T Operation<T, K>(K val);

        public static void Main()
        {
            UserInterface.HelloMessage();

            double DoOperation(double x, double y, Operation op)
            {
                return op(x, y);
            }

            UserInterface.AddFunctionsToEvent();

            while (true)
            {
                UserInterface.UserMenu();

                UserInterface.EntireOperations();
                var userChoice = UserInterface.GetUserChoice();

                if (userChoice == "sqrt")
                {
                    UserInterface.EntireNumberForSquareRoot();
                    var numberOne = UserInterface.GetNumber();
                    if (numberOne == default) continue;

                    if (numberOne < 0)
                    {
                        OutputResultOrError.NegativeNumber();
                        continue;
                    }

                    UserInterface.EntireSquareRootExponent();
                    var numberTwo = UserInterface.GetNumber();
                    if (numberTwo == default) continue;

                    OutputResultOrError.OuputResult(DoOperation(numberOne, numberTwo, CalculatorOperations.SquareRoot));
                    continue;
                }
                else if (userChoice == "^")
                {
                    UserInterface.EntireNumberForExponentiation();
                    var numberOne = UserInterface.GetNumber();
                    if (numberOne == default) continue;

                    UserInterface.EntireExponentiationPower();
                    var numberTwo = UserInterface.GetNumber();
                    if (numberTwo == default) continue;

                    OutputResultOrError.OuputResult(DoOperation(numberOne, numberTwo, CalculatorOperations.Exponentiation));
                    continue;
                }
                else if (userChoice == "+" || userChoice == "-" || userChoice == "*" || userChoice == "/")
                {
                    UserInterface.EntireNumberOne();
                    var numberOne = UserInterface.GetNumber();
                    if (numberOne == default) continue;

                    UserInterface.EntireNumberTwo();
                    var numberTwo = UserInterface.GetNumber();
                    if (numberTwo == default) continue;

                    switch (userChoice)
                    {
                        case "+":
                            OutputResultOrError.OuputResult(DoOperation(numberOne, numberTwo, CalculatorOperations.Addition));
                            continue;
                        case "-":
                            OutputResultOrError.OuputResult(DoOperation(numberOne, numberTwo, CalculatorOperations.Subtraction));
                            continue;
                        case "*":
                            OutputResultOrError.OuputResult(DoOperation(numberOne, numberTwo, CalculatorOperations.Multiplication));
                            continue;
                        case "/":
                            OutputResultOrError.OuputResult(DoOperation(numberOne, numberTwo, CalculatorOperations.Division));
                            continue;
                    }
                }
                else if (userChoice == "q") break;
                else OutputResultOrError.InvalidOperators();
            }
        }
    }
}