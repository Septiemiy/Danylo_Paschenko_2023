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

                switch (userChoice)
                {
                    case "q":
                        break;

                    case "sqrt":
                        var numberOneSR = UserInterface.GetSquareRootNumber();
                        if (numberOneSR < 0)
                        {
                            OutputResultOrError.NegativeNumber();
                            continue;
                        }

                        var numberTwoSR = UserInterface.GetSquareRootNumber();

                        if (numberOneSR != default || numberTwoSR != default)
                        {
                            OutputResultOrError.OuputResult(DoOperation(numberOneSR, numberTwoSR, CalculatorOperations.SquareRoot));
                            continue;
                        }
                        else continue;

                    case "^":
                        var numberOneExp = UserInterface.GetExponentiationNumber();
                        var numberTwoExp = UserInterface.GetExponentiationPowerNumber();

                        if (numberOneExp != default || numberTwoExp != default)
                        {
                            OutputResultOrError.OuputResult(DoOperation(numberOneExp, numberTwoExp, CalculatorOperations.Exponentiation));
                            continue;
                        }
                        else continue;

                    case "+":
                        var numberOneAdd = UserInterface.GetNumberOne();
                        var numberTwoAdd = UserInterface.GetNumberTwo();

                        if (numberOneAdd != default || numberTwoAdd != default)
                        {
                            OutputResultOrError.OuputResult(DoOperation(numberOneAdd, numberTwoAdd, CalculatorOperations.Addition));
                            continue;
                        }
                        else continue;

                    case "-":
                        var numberOneSub = UserInterface.GetNumberOne();
                        var numberTwoSub = UserInterface.GetNumberTwo();

                        if (numberOneSub != default || numberTwoSub != default)
                        {
                            OutputResultOrError.OuputResult(DoOperation(numberOneSub, numberTwoSub, CalculatorOperations.Subtraction));
                            continue;
                        }
                        else continue;

                    case "*":
                        var numberOneMult = UserInterface.GetNumberOne();
                        var numberTwoMult = UserInterface.GetNumberTwo();

                        if (numberOneMult != default || numberTwoMult != default)
                        {
                            OutputResultOrError.OuputResult(DoOperation(numberOneMult, numberTwoMult, CalculatorOperations.Multiplication));
                            continue;
                        }
                        else continue;

                    case "/":
                        var numberOneDiv = UserInterface.GetNumberOne();
                        var numberTwoDiv = UserInterface.GetNumberTwo();

                        if (numberOneDiv != default || numberTwoDiv != default)
                        {
                            OutputResultOrError.OuputResult(DoOperation(numberOneDiv, numberTwoDiv, CalculatorOperations.Division));
                            continue;
                        }
                        else continue;

                    default:
                        OutputResultOrError.InvalidOperators();
                        continue;
                }
                break;
            }
        }
    }
}