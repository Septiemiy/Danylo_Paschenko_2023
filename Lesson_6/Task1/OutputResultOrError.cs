using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class OutputResultOrError
    {
        public delegate void MessageHandler(string message);
        public static event MessageHandler? NotifyResult;
        public static event MessageHandler? NotifyError;

        public static void InvalidNumberError() => NotifyError?.Invoke("\nThe entered number is invalid");

        public static void InvalidOperators() => NotifyError?.Invoke("\nThe entered operator is invalid");

        public static void NegativeNumber() => NotifyError?.Invoke("\nNegative number under square root");

        public static void OuputResult(double result) => NotifyResult?.Invoke($"\nResult: {result}");
    }
}
