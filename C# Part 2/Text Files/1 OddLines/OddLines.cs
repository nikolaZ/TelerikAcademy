//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;

    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"C:\test.txt");
            string text = string.Empty;
            using (reader)
            {
                text = reader.ReadLine();
                int lineOdd = 1;
                while (text != null)
                {
                    if (lineOdd % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}",
                            lineOdd, text);
                        text = reader.ReadLine();
                    }
                    lineOdd++;
                }

            }

        }
    }

