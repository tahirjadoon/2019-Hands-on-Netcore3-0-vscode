using System;
using System.IO;

namespace ReadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "username.csv";
            if (!File.Exists(fileName)){
                Console.WriteLine($"{fileName} not found!");
            }
            else{
                var file = new StreamReader("username.csv");
                var counter = 0;
                string line;
                while((line = file.ReadLine()) != null)
                {
                    var values = line.Split(",");
                    //we don't want to display the header line, so will skip when counter = 0
                    if(counter != 0){
                        Console.WriteLine($"First Name: {values[2]}"); //index is 0 based
                        Console.WriteLine($"\tUsername: {values[0]}");
                        Console.WriteLine($"\tIdentifier: {values[1]}");
                        Console.WriteLine($"\tLast name: {values[3]}");
                    }
                    counter++;
                }    
                Console.WriteLine($"There are {counter-1} line in the file.");
                file.Close();
            }
        }
    }
}
