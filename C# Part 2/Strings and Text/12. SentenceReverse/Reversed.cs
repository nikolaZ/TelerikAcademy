//Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ReverseSentence
    {
        static void Main()
        {
            string sentence="C# is not C++ , not PHP and not Delphi!";
            Reverse(sentence);
        }
        static void Reverse(string sentence)
        {
            string del = " ";
            int index = 0;
            //int count = 0;
            List<string> reversed = new List<string>();
            while (sentence.IndexOf(del, index) > 0)
            {
                int indexEnd = sentence.IndexOf(del, index);
                string server = sentence.Substring(index, indexEnd - index);
                reversed.Add(server);
                Console.WriteLine(server);
                sentence = sentence.Remove(index, indexEnd - index + del.Length);
                index = 0;
            }
            string[] end = new string[] { ".", "!", "?", "!?", "?!", "..." };
            for (int i = 0; i < end.Length; i++)
            {
                index = 0;
                int indexEnd = sentence.IndexOf(end[i], index);
                if (indexEnd >= 0)
                {
                    string server = sentence.Substring(index, indexEnd - index);
                    reversed.Add(server);
                    Console.WriteLine(server);
                    sentence = sentence.Remove(index, indexEnd - index);
                }
                index = 0;
            }
            reversed.Add(sentence);
            StringBuilder result = new StringBuilder();
            for (int i = reversed.Count-2; i >=0; i--)
            {
                result.Append(reversed[i]);
                result.Append(" ");
            }
            result.Append(reversed[reversed.Count - 1]);
            Console.WriteLine(result.ToString());
        }
    }

