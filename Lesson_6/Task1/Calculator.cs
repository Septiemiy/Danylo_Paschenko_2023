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
                    case "-":
                    case "*":
                    case "/":
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