//Write a program that reads a text file containing a list of strings, 
//sorts them and saves them to another text file. Example:
//    Ivan			George
//    Peter			Ivan
//    Maria			Maria
//    George			Peter
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

    class SortFile
    {
        static void Main()
        {
            ReadNames();           
        }
        static void ReadNames()
        {
            StreamReader input = new StreamReader(@"C:\txt.txt");
            StreamWriter output = new StreamWriter(@"C:\txt.txt");
            List<string> listNames = new List<string>();
            using (input)
            {
                string name = string.Empty;
                while (name!=null)
                {
                    name = input.ReadLine();
                    if (name!=null)
                    {                   
                    listNames.Add(name);
                    }
                }
            }
            listNames.Sort();
            using (output)
            {
                foreach (var item in listNames)
                {
                    output.WriteLine(item);
                }
            }
        }
    }

