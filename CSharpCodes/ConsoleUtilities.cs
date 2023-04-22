using System;
using System.Threading;

namespace CSharpCodes
{
    public class ConsoleUtilities
    {
        public static void LoadingScreen()
        {
            Console.Write("Loading");

            var dotCount = 0;
            const int timeinterval = 500;
            while (true)
            {
                // Add a dot and print the message
                Console.Write(".");
                dotCount++;

                // Reset the dots after 3
                if (dotCount == 3)
                {
                    Thread.Sleep(timeinterval);
                    Console.Write("\b\b\b   \b\b\b"); // Remove the dots
                    dotCount = 0;
                }

                // Wait for 500 milliseconds
                Thread.Sleep(timeinterval);
            }
        }
    }
}