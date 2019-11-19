using System;
using System.Collections.Generic;

namespace _02_CsvToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            //test csv path
            var filePath = @"C:\Training\Learning-Examples\ASPNetCore\2019-Hands-on-Netcore3-0\02-CsvToHtml";
            //file to read
            var file = @"test.csv";
            //will tell us the number of lines in the csv file
            var counter = 0;
            //using the stream reader, we'll read line by line from the file
            var line = "";
            //since we are converting the comma separated file into HTML, create a string so that we can write the data as html
            var htmlString = "<h1>Users</h1>\n<table border=1>\n";

            //read the file using the stream reader
            System.IO.StreamReader csvFile =  new System.IO.StreamReader(filePath + @"\" + file);

            //use a while loop to read the lines
            while((line = csvFile.ReadLine()) != null)
            {
                //split the line
                string[] tempLine = line.Split(',');
                //add the row
                htmlString += "\t<row>\n";
                //first row in the csv is the header so read the content in create columns;
                foreach(var data in tempLine)
                {
                    if(counter == 0)
                    {
                        //table header
                        htmlString += "\t\t<th>" + data + "</th>\n";
                    }
                    else
                    {
                        //table data
                        htmlString += "\t\t<td>" + data + "</td>\n";
                    }
                }
                //end the table row
                htmlString += "\t</row>\n";
                //increment the counter
                counter++;
            }

            //end the table
            htmlString += "</table>";

            //write the string
            Console.WriteLine(htmlString);
            //write to an external file as well
            System.IO.File.WriteAllText(filePath + "\\test.html", htmlString);

            //close the file
            csvFile.Close();

            //ask the user to exit
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
