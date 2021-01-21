using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            int[] Numbers = new int[3];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            //Params keyword allow this method to run without parameter
            //ParamsMethod();

            ParamsMethod(Numbers);

            //Params keyword allow this method to take as many values as parameter
            //ParamsMethod(1,2,3,4,5,6)
        }

        //We use params keyword to make parameter optional
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements", Numbers.Length);

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
