using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {       
            Program P = new Program();
            int Sum = P.AddNumbers(2,4);

            Console.WriteLine("Sum of 2 and 4 is {0}", Sum);
        }

        //Instance method
        public int AddNumbers(int FirstNumber, int SecondNumber) 
        {
            return FirstNumber + SecondNumber;
        }
    }
}
