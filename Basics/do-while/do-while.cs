using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            string UserChoice = string.Empty;

            //Repeat till the user choice is yes
            do
            {
                Console.WriteLine("Please enter your target:");
                int UserTarget = int.Parse(Console.ReadLine());

                int Number = 0;

                while (Number <= UserTarget)
                {
                    Console.Write(Number + " ");
                    Number = Number + 2;
                }

                //Repeat till the user choice is not yes or no
                do
                {
                    Console.WriteLine("Do you want to continue: Yes or No ?");
                    UserChoice = Console.ReadLine().ToLower();

                    if (UserChoice != "yes" && UserChoice != "no")
                    {
                        Console.WriteLine("Invalid choice. Please enter Yes or No");
                    }
                } while (UserChoice != "yes" && UserChoice != "no");

            } while (UserChoice == "yes");

        }
    }
}
