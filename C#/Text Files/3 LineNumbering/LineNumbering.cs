//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.
using System;
using System.IO;

    class LineNumbering
    {
        static void Main()
        {
            StreamReader input = new StreamReader(@"C:\input.txt");
            StreamWriter output = new StreamWriter(@"C:\output.txt");
            string line = string.Empty;
            string textFile = string.Empty;
            using (input)
            {
                using (output)
                {
                    int lineCount = 1;
                    while (line != null)
                    {
                        line = input.ReadLine();
                        output.WriteLine("{0}. {1}", lineCount, line);
                        lineCount++;
                    }
                }
            }
        }
    }

