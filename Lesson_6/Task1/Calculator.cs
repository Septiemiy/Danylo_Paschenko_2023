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
                        UserInterface.EntireNumberForSquareRoot();
                        var numberOneSR = UserInterface.GetNumber();
                        if (numberOneSR == default) continue;

                        if (numberOneSR < 0)
                        {
                            OutputResultOrError.NegativeNumber();
                            continue;
                        }

                        UserInterface.EntireSquareRootExponent();
                        var numberTwoSR = UserInterface.GetNumber();
                        if (numberTwoSR == default) continue;

                        OutputResultOrError.OuputResult(DoOperation(numberOneSR, numberTwoSR, CalculatorOperations.SquareRoot));
                        continue;

                    case "^":
                        UserInterface.EntireNumberForExponentiation();
                        var numberOneExp = UserInterface.GetNumber();
                        if (numberOneExp == default) continue;

                        UserInterface.EntireExponentiationPower();
                        var numberTwoExp = UserInterface.GetNumber();
                        if (numberTwoExp == default) continue;

                        OutputResultOrError.OuputResult(DoOperation(numberOneExp, numberTwoExp, CalculatorOperations.Exponentiation));
                        continue;

                    case "+":
                        UserInterface.EntireNumberOne();
                        var numberOneAdd = UserInterface.GetNumber();
                        if (numberOneAdd == default) continue;

                        UserInterface.EntireNumberTwo();
                        var numberTwoAdd = UserInterface.GetNumber();
                        if (numberTwoAdd == default) continue;

                        OutputResultOrError.OuputResult(DoOperation(numberOneAdd, numberTwoAdd, CalculatorOperations.Addition));
                        continue;

                    case "-":
                        UserInterface.EntireNumberOne();
                        var numberOneSub = UserInterface.GetNumber();
                        if (numberOneSub == default) continue;

                        UserInterface.EntireNumberTwo();
                        var numberTwoSub = UserInterface.GetNumber();
                        if (numberTwoSub == default) continue;

                        OutputResultOrError.OuputResult(DoOperation(numberOneSub, numberTwoSub, CalculatorOperations.Subtraction));
                        continue;

                    case "*":
                        UserInterface.EntireNumberOne();
                        var numberOneMult = UserInterface.GetNumber();
                        if (numberOneMult == default) continue;

                        UserInterface.EntireNumberTwo();
                        var numberTwoMult = UserInterface.GetNumber();
                        if (numberTwoMult == default) continue;

                        OutputResultOrError.OuputResult(DoOperation(numberOneMult, numberTwoMult, CalculatorOperations.Multiplication));
                        continue;

                    case "/":
                        UserInterface.EntireNumberOne();
                        var numberOneDiv = UserInterface.GetNumber();
                        if (numberOneDiv == default) continue;

                        UserInterface.EntireNumberTwo();
                        var numberTwoDiv = UserInterface.GetNumber();
                        if (numberTwoDiv == default) continue;

                        OutputResultOrError.OuputResult(DoOperation(numberOneDiv, numberTwoDiv, CalculatorOperations.Division));
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