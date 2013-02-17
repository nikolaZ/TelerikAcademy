//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Polindromes
    {
        static void Main()
        {
            string text = "Static void Main() ABBA, using System lamal, exe.";
            Polindromes(text);
        }
        static void Polindromes(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.',',', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                bool polindrome = true;
                for (int j = 0; j < words[i].Length/2; j++)
                {
                    string current = words[i];
                    if (current[j]!=current[current.Length-1-j])
                    {
                        polindrome = false;
                        break;
                    }
                }
                if (polindrome)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }

