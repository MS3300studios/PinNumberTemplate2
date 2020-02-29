using System;

namespace PinNumberTemplateCsharp
{
    class Program
    {
        const string PIN = "1234";

        static void Main(string[] args)
        {
            Pin();
        }

        static void Pin()
        {           
            for (int i = 3; i > 0; i--)
            {                
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the PIN number: ");
                string user_input = Console.ReadLine();
                if (user_input==PIN)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct Pin!");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect Pin, try again.");
                    Console.Write($"Attempts left: {i-1}");
                    Console.WriteLine("");
                }

            }
        }
    
    }
}
