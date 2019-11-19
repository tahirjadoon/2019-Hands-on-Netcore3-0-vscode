using System;
using System.Linq;

namespace NameLength
{
    class Program
    {
        static void Main(string[] args)
        {
            //receiving the name and approach to use as an argument.
            Console.WriteLine(args[0]+"-"+args[1]);  
            Console.WriteLine(charsInName(args[0], args[1]));
        }

        static int charsInName(string name, string approach){
            var counter = 0;
            //we can use .length but we are counting the characters only
            //counter = name.Length;
            switch (approach){
                case "1":
                    //approach 1 with loop  
                    foreach(char c in name){
                        if(Char.IsLetter(c)) counter++;
                    }
                    break;
                case "2":
                    //approach 2 for counting the characters only. ref System.Linq
                    counter = name.Where(x => Char.IsLetter(x)).ToArray().Count();
                    break;
                case "3":
                    //approach 3 for counting the characters only. ref System.Linq
                    counter = name.ToCharArray().Count(x => Char.IsLetter(x));
                    break;
            }
            return counter;
        }
    }
}
