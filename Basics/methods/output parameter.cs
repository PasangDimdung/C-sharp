using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            int Total = 0;
            int Product = 0;

            Calculate(5,2, out Total, out Product);

            Console.WriteLine("Sum is {0} and Product is {1}", Total, Product);
        }

        //Output parameter
        public static void Calculate( int FirstNumber, int SecondNumber, out int Sum, out int Product)
        {
            Sum = FirstNumber + SecondNumber;
            Product = FirstNumber * SecondNumber;
        }
    }
}
