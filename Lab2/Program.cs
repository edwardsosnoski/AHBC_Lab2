using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuePrompt = false;
            do
            {
                Console.WriteLine("Welcome to Grand Circus's Room Detail Generator!");
                Console.WriteLine("Enter Length:");
                string userRoomLength = Console.ReadLine();
                Console.WriteLine("Enter Width:");
                string userRoomWidth = Console.ReadLine();

                double roomArea = (double.Parse(userRoomLength) * double.Parse(userRoomWidth));
                double roomPerimeter = ((double.Parse(userRoomLength) * 2) + (double.Parse(userRoomWidth) * 2));

                Console.WriteLine($"Area: {roomArea}");
                Console.WriteLine($"Perimeter: {roomPerimeter}");

                Console.WriteLine("Continue? (y/n)");
                string userContinuePrompt = Console.ReadLine();

                if (userContinuePrompt == "y")
                {
                    continuePrompt = true;
                }
                else
                {
                    continuePrompt = false;
                }
            }
            while (continuePrompt);
        }
    }
}
