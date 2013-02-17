//Write a program that deletes from given text file all odd lines. The result should be in the same file.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

    class EvenLines
    {
        static void Main()
        {
            Writer(GetEven());
        }
        static List<string> GetEven()
        {
            StreamReader reader = new StreamReader(@"C:\reader.txt");
            string text = string.Empty;
            List<string> even = new List<string>();
            using (reader)
            {
                int lineEven = 1;
                while (text != null)
                {
                    text = reader.ReadLine();
                    if (text == null)
                    {
                        break;
                    }
                    if (lineEven % 2 == 0)
                    {
                        even.Add(text);
                    }
                    lineEven++;
                }
            }
            return even;
        }
        static void Writer(List<string> list)
        {
            StreamWriter output = new StreamWriter(@"C:\output.txt");
            using (output)
            {
                foreach (var item in list)
                {
                    output.WriteLine(item);
                }
            }
        }
    }
    

