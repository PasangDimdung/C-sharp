using System;
using System.Threading;

namespace ThreadingDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter target number:");
            int target = Convert.ToInt32(Console.ReadLine());

            //passing data to thread function in type safe manner
            Number number = new Number(target);      
            Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();
        }
    }

    class Number
    {
        private int _target;
        public Number(int target)
        {
            _target = target;
        }

        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
