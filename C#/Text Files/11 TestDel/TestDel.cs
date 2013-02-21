//Write a program that deletes from a text file all words that start with the prefix "test".
//Words contain only the symbols 0...9, a...z, A…Z, _.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

    class TestDel
    {
        static void Main()
        {
            StreamReader input = new StreamReader(@"C:\input.txt");
            StreamWriter output = new StreamWriter(@"C:\output.txt");
            RemovePrefix(input, output);
        }
        static void RemovePrefix(StreamReader input, StreamWriter output)
        {
            using (input)
            {
                using (output)
                {
                    string line = string.Empty;
                    string clear = string.Empty;
                    while (true)
                    {
                        line = input.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        line = Regex.Replace(line, @"\btest\w*\b", clear);
                        output.WriteLine(line);
                    }
                }
            }
        }
    }

