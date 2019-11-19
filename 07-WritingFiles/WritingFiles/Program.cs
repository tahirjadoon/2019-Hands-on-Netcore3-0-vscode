using System;
using System.IO;

namespace WritingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "test.txt";
            string[] lines = {"One", "Two", "Three"};
            if(File.Exists(file)){
                //File.AppendAllText(file, "This is another line!\n");
                
                //will overwrite the file with new lines
                //File.WriteAllLines(file, lines);

                //will append the lines
                File.AppendAllLines(file, lines);
                
                //File.WriteAllBytes(file, someArray);
            }
            else{
                File.WriteAllText(file, "This is some text!\n");
            }
            
        }
    }
}
