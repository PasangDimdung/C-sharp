using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {       
            Program.EvenNumbers();
        }

        //Static method
        public static void EvenNumbers() 
        {
            int Start = 0;

            while (Start <= 20)
            {
                Console.WriteLine(Start);

                Start = Start + 2;
            }
        }
    }
}
