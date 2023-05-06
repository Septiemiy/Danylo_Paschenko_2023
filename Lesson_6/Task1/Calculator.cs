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
                if (userChoice == "q") break;

                var numberOne = UserInterface.GetNumberOne();
                var numberTwo = UserInterface.GetNumberTwo();

                if (numberOne == default || numberTwo == default) continue; 

                    switch (userChoice)
                    {

                    case "sqrt":
                        
                        if (numberOne < 0)
                        {
                            OutputResultOrError.NegativeNumber();
                            continue;
                        }
                        
                        OutputResultOrError.OuputResult(DoOperation(numberOne, numberTwo, CalculatorOperations.SquareRoot));
                        continue;

                    case "^":

                        OutputResultOrError.OuputResult(DoOperation(numberOne, numberTwo, CalculatorOperations.Exponentiation));
                        continue;

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

                    default:
                        OutputResultOrError.InvalidOperators();
                        continue;
                }
                break;
            }
        }
    }
}