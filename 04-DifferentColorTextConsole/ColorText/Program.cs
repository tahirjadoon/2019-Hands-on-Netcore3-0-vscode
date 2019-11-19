using System;

namespace ColorText
{
    class Program
    {
        static void Main(string[] args)
        {
            displayMessage("Starting Program", null);
            displayMessage("Checking Permissions", null);
            displayMessage("Permissions are correct", ConsoleColor.Cyan);
            displayMessage("Pinging Server", ConsoleColor.White);
            displayMessage("Warning:Pinging response is over 1 second", ConsoleColor.Yellow);
            displayMessage("Checking database", ConsoleColor.White);
            displayMessage("Error: Database not reachable", ConsoleColor.Red);
            double percentage = 0.40;  
            displayMessage($"Percentage = {percentage:0.0%}", ConsoleColor.Green);
            int sin = 526193526; //some SIN number, display as 526-193-526
            displayMessage($"Some SIN = {sin:000-000-000}", ConsoleColor.Blue);
            long phone = 9051234560;
            displayMessage($"Phone = {phone:(000) 000-0000}", ConsoleColor.Green);
            double cur = 45610.05;
            displayMessage($"Currency = {cur:c}", ConsoleColor.Blue);
            displayMessage($"Currency = {cur:n3}", ConsoleColor.Green);
            displayMessage(string.Empty, ConsoleColor.White);
        }
        static void displayMessage(string message, ConsoleColor? color)
        {
            if(color != null) 
                Console.ForegroundColor = color.GetValueOrDefault();
            if(!string.IsNullOrWhiteSpace(message)) 
                Console.WriteLine(message);
        }
    }
}
