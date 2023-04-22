using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodes
{
    internal class FastType
    {
        private readonly Random _random = new Random();

        public void Play()
        {
            Console.WriteLine("Welcome to Fast Typing Practice!");

            // Get the characters for this session
            char[] sessionChars = GetSessionChars(' ', 'f', 'j', 'k', 'd'); // You can adjust the allowed characters here

            // Print the session characters to the console
            Console.WriteLine($"Type the following characters: {new string(sessionChars)}");

            // Start the session timer
            int sessionSeconds = 30;
            DateTime sessionEndTime = DateTime.Now.AddSeconds(sessionSeconds);

            // Initialize the mistake counter
            int mistakeCount = 0;

            // Loop until time runs out
            while (DateTime.Now < sessionEndTime)
            {
                // Clear the console and reprint the session characters
                Console.Clear();
                Console.WriteLine($"Type the following characters: {new string(sessionChars)}");

                // Read user input
                string userInput = Console.ReadLine();

                // Check if input matches session characters
                bool inputMatches = true;
                for (int i = 0; i < sessionChars.Length; i++)
                {
                    if (i >= userInput.Length || userInput[i] != sessionChars[i])
                    {
                        inputMatches = false;
                        break;
                    }
                }

                if (inputMatches)
                {
                    // Input is correct, generate new session characters
                    sessionChars = GetSessionChars(' ', 'f', 'j', 'k', 'd');
                }
                else
                {
                    // Input is incorrect, increment mistake counter
                    mistakeCount++;
                }
            }

            // Print results
            Console.Clear();
            Console.WriteLine($"Time's up! You made {mistakeCount} mistake{(mistakeCount == 1 ? "" : "s")}. Press any key to exit.");
            Console.ReadKey();
        }

        private char[] GetSessionChars(params char[] allowedChars)
        {
            // Generate an array of 30 random characters from the allowedChars array
            char[] sessionChars = new char[30];
            for (int i = 0; i < sessionChars.Length; i++)
            {
                sessionChars[i] = allowedChars[_random.Next(allowedChars.Length)];
            }
            return sessionChars;
        }
    }
    
}
