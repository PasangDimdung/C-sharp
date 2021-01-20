using System;

namespace CSharp
{
    class Program
    {
        static void Main()
        {
            int TotalCoffeeCost = 0;

        Start:
            Console.WriteLine("Please select your coffee size : 1- Small 2- Medium 3- Large");

            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost = TotalCoffeeCost + 1;
                    break;
                case 2:
                    TotalCoffeeCost = TotalCoffeeCost + 2;
                    break;
                case 3:
                    TotalCoffeeCost = TotalCoffeeCost + 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Please enter valid choice..", UserChoice);
                    goto Start;
            }

        Decision:
            Console.WriteLine("Do you want another coffee ? Yes or No: ");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToLower())
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please enter valid decision");
                    goto Decision;
            }

            Console.WriteLine("Thank you for purchasing coffee!");
            Console.WriteLine("Your bill amount is {0}", TotalCoffeeCost);
        }
    }
}
