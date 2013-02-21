//Write a program that compares two text files line by line and prints the number of lines
//that are the same and the number of lines that are different. 
//Assume the files have equal number of lines.
using System;
using System.IO;

    class CompareFiles
    {
        static void Main()
        {
            StreamReader input = new StreamReader(@"C:\input.txt");
            StreamReader input2 = new StreamReader(@"C:\input2.txt");
            string line = string.Empty;
            string line2 = string.Empty;
            int countEqual = 0;
            int countNotEqual = 0;
            using (input)
            {
                using (input2)
                {
                    while (line!=null&&line2!=null)
                    {
                        line = input.ReadLine();
                        line2 = input2.ReadLine();
                        if (line==line2&&line2!=null)
                        {
                            countEqual++;
                        }
                        else if(line2!=null)
                        {
                            countNotEqual++;
                        }
                    }
                    Console.WriteLine(countEqual);
                    Console.WriteLine(countNotEqual);
                }
            }
        }
    }

