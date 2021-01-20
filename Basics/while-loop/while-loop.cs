using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your target:");
            int UserTarget = int.Parse(Console.ReadLine());

            int Number = 0;

            while(Number <= UserTarget) {
                Console.Write(Number + " ");
                Number = Number + 2;
            } 
        }
    }
}
