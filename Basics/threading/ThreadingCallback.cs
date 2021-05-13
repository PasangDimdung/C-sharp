using System;
using System.Threading;

namespace ThreadingCallback
{
    public delegate void SumOfNumbersCallback(int SumOfNumbers);
    class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of numbers = " + sum);
        }
        public static void Main()
        {
            Console.WriteLine("Enter target number:");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSum);
            Number number = new Number(target, callback);
            Thread T1 = new Thread(number.ComputeSumOfNumbers);
            T1.Start();
        }
    }

    class Number
    {
        int _target;
        SumOfNumbersCallback _callbackMethod;
        public Number(int target, SumOfNumbersCallback callbackMethod)
        {
            _target = target;
            _callbackMethod = callbackMethod;
        }

        public void ComputeSumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum = sum + i;
            }

            if(_callbackMethod != null)
            {
                _callbackMethod(sum);
            }
        }
    }
}
