//Write a program that replaces all occurrences of the substring "start" 
//with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

    class ReplaceWord
    {
        static void Main()
        {
            StreamReader input = new StreamReader(@"C:\txt.txt");
            StreamWriter output = new StreamWriter(@"C:\txt1.txt");
            Replace(input, output);
        }
        static void Replace(StreamReader input, StreamWriter output)
        {
            using (input)
            {
                using (output)
                {
                    string line=string.Empty;
                    while (true)
                    {
                        line = input.ReadLine();
                        if (line==null)
                        {
                            break;
                        }
                        line=line.Replace("start", "finish");
                        output.WriteLine(line);
                    }
                }
            }
        }
    }

