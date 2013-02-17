//Modify the solution of the previous problem(Task 7: ReplaceWord) to replace only whole words (not substrings).
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

    class ReplaceWordOnly
    {
        static void Main()
        {
            StreamReader input = new StreamReader(@"C:\input.txt");
            StreamWriter output = new StreamWriter(@"C:\output.txt");
            Replace(input, output);
        }
        static void Replace(StreamReader input, StreamWriter output)
        {
            using (input)
            {
                using (output)
                {
                    string line = string.Empty;
                    while (true)
                    {
                        line = input.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        line = Regex.Replace(line,@"\bstart\b", "finish");
                        output.WriteLine(line);
                    }
                }
            }
        }
    }

