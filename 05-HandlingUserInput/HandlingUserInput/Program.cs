using System;

namespace HandlingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //every thing on new line
            displayMessage("What is your name?", true, ConsoleColor.Green, true);
            var name = Console.ReadLine();
            displayMessage($"You have entered: {name}", true, ConsoleColor.Blue, true);
            //Same line
            Console.WriteLine();
            displayMessage("What is your name? ", false, ConsoleColor.Green, true);
            name = Console.ReadLine();
            displayMessage($"You have entered: {name}", true, ConsoleColor.Blue, true);
        }

        static void displayMessage(string message, bool isNewLine, ConsoleColor? color, bool isChangeToWhite)
        {
            if(color != null) 
                Console.ForegroundColor = color.GetValueOrDefault();
            if(!string.IsNullOrWhiteSpace(message)){
                if(isNewLine)
                    Console.WriteLine(message);
                else 
                    Console.Write(message);
            }
            if(isChangeToWhite) Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
