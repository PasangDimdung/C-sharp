using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {       
            int i = 0;

            SimpleMethod(i);

            //Prints zero because i and j are pointing in different memory location
            Console.WriteLine(i);
        }

        //Passing a parameter by value
        public static void SimpleMethod(int j) 
        {
            j = 101;
        }
    }
}
