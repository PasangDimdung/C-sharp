using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            int i = 0;

            SimpleMethod(ref i);

            /*
            Prints 101 because i and j are pointing to the same memory location. 
            Simple method puts the value 101 to the memory when called.
            */
            Console.WriteLine(i);
        }

        //Passing a parameter by reference
        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }
    }
}
