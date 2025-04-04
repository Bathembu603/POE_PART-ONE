using System;
using System.Collections.Generic;
using System.Threading;

namespace voice_greeting
{
    public class CyberSecurityBot
    {
        private Dictionary<string, string> responses;

        // Constructor to initialize responses
        public CyberSecurityBot()
        {
            responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "how are you?", "I'm just a bot, but I'm here to help you stay secure!" },
                { "what's your purpose?", "I am a Cybersecurity Awareness Bot! I provide tips to keep you safe online." },
                { "what can i ask you about?", "You can ask me about:\n🔹 Password Safety\n🔹 Phishing Awareness\n🔹 Safe Browsing\n🔹 Cybersecurity Tips!" },
                { "tell me about password safety?", " Always use strong passwords with at least 12 characters, including numbers and symbols. Consider a password manager!" },
                { "what is phishing?", "Phishing is a type of cyber attack where scammers try to trick you into providing personal information. Never click on suspicious links!" },
                { "how can i browse safely?", "Keep your browser updated, use a secure connection (HTTPS), and avoid downloading files from unknown sources." },
                { "how do i create a strong password?", "Use a mix of uppercase, lowercase, numbers, and symbols. Avoid common words and don't reuse passwords across sites!" },
{ "what should i do if i suspect phishing?", "Do not click any links! Verify the sender, check for spelling errors, and report suspicious emails to your IT department or service provider." },
{ "why is two-factor authentication important?", "2FA adds an extra layer of security by requiring a second verification step, like a code sent to your phone, making it harder for hackers to access your account." },
{ "how can i protect my personal information online?", "Limit what you share on social media, use privacy settings, and be cautious of websites asking for personal details." },
{ "what are some common cybersecurity threats?", "Common threats include phishing, malware, ransomware, data breaches, and social engineering attacks. Always stay alert and use strong security measures!" }

            };
        }

        // Simulated Typing Effect
        private void TypeResponse(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30); // Simulate typing delay
            }
            Console.WriteLine();
        }

        // Method to get a response based on user input
        public void RespondToUser(string userInput)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nBot: ");
            Console.ResetColor();

            if (responses.ContainsKey(userInput))
            {
                TypeResponse(responses[userInput]);
            }
            else
            {
                TypeResponse("I'm not sure about that. Try asking about cybersecurity topics!");
            }

            Console.WriteLine(new string('-', 50)); // Divider for readability
        }
    }
}
