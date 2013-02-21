//Write a program that reads a string from the console and lists all different words
//in the string along with information how many times each word is found.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class WordsCount
    {
        static void Main()
        {
            string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. ";
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] = dictionary[word] + 1;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }
            foreach (var word in dictionary)
            {
                Console.WriteLine("{0}: {1}", word.Key, word.Value);
            }
        }
    }

