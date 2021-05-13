using System;

namespace FuncDelegate
{
    class Program
    {
        public static void Main()
        {
            Func<int, int, string> funcDelegate = (firstNumber, secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();

            string result = funcDelegate(10, 20);
            Console.WriteLine(result);
        }
    }
}
