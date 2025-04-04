using System;
using System.Threading;
using System.Drawing;
using System.IO;

namespace voice_greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display ASCII logo and play greeting sound
            WelcomeMessage welcome = new WelcomeMessage();
            new Logo() { }; // Convert image to ASCII logo
            

            // Ask for the user's name
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nBot: Hello! What's your name? \nYou: ");
            Console.ResetColor();

            string userName = Console.ReadLine().Trim();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nBot: Thank you, {userName}! How can I help you today? 😊");
            Console.ResetColor();

            // Create chatbot instance
            CyberSecurityBot bot = new CyberSecurityBot();

            // Display chatbot instructions
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n💬 Ask me a question about cybersecurity! Type 'exit' to quit.");
            Console.WriteLine(new string('=', 50));
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nBot: Goodbye, {userName}! Stay safe online. 🛡️");
                    Console.ResetColor();
                    break;
                }

                bot.RespondToUser(userInput);
                Thread.Sleep(500); // Small delay to make the interaction feel natural
            }
        }
    }
}
