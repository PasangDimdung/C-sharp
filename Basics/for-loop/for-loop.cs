using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            int [] Numbers = new int [3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            for(int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }

        }
    }
}
