//Write a program that reads a string from the console and replaces all series 
//of consecutive identical letters with a single one. 
//Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SingleLetter
    {
        static void Main()
        {
            string text = "Write a aaaaabbbbbcdddeeeedssaa, reads a string froooooopppppppppppppssssssssooqqqqq ";
            Extract(text);         
        }
        static void Extract(string text)
        {
            StringBuilder textStr = new StringBuilder(text);
            int index = 0;
            for (int i = 0; i < textStr.Length - 1; i++)
            {
                char current = textStr[i];
                while (index < textStr.Length - 1 && current == textStr[index + 1])
                {
                    textStr.Remove(index + 1, 1);
                }
                index++;
            }
            Console.WriteLine(textStr);
        }
    }

