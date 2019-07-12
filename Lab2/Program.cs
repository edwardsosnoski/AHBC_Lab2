using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuePrompt;
            bool completeLengthPrompt;
            bool completeWidthPrompt;
            double parsedRoomLength;
            double parsedRoomWidth;
            Console.WriteLine("Welcome to Grand Circus's Room Detail Generator!");

            do
            {
                do
                {
                    Console.WriteLine("Enter Length:");
                    string userRoomLength = Console.ReadLine();

                    if (double.TryParse(userRoomLength, out parsedRoomLength))
                    {
                        completeLengthPrompt = true;
                    }
                    else
                    {
                        completeLengthPrompt = false;
                        Console.WriteLine("That's not a valid length. Please enter a number.");
                    }
                }
                while (!completeLengthPrompt);

                do
                {
                    Console.WriteLine("Enter Width:");
                    string userRoomWidth = Console.ReadLine();

                    if (double.TryParse(userRoomWidth, out parsedRoomWidth))
                    {
                        completeWidthPrompt = true;
                    }
                    else
                    {
                        completeWidthPrompt = false;
                        Console.WriteLine("That's not a valid width. Please enter a number.");
                    }
                }
                while (!completeWidthPrompt);

                double roomArea = parsedRoomLength * parsedRoomWidth;
                double roomPerimeter = (parsedRoomLength * 2) + (parsedRoomWidth * 2);

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