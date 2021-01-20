using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {       
            Program.EvenNumbers(20);
        }

        //Static method
        public static void EvenNumbers(int Target) 
        {
            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);

                Start = Start + 2;
            }
        }
    }
}
