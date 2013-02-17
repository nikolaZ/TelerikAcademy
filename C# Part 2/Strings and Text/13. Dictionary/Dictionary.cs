//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"};
        string search = ".NET";
        Search(dictionary, search);
    }
    static void Search(string[] dict, string word)
    {
        string del = " - ";
        int index = 0;
        List<string> words = new List<string>();
        List<string> definitions = new List<string>();
        for (int i = 0; i < dict.Length; i++)
        {
            string dictionary = dict[i];
            while (dictionary.IndexOf(del, index) > 0)
            {
                int indexEnd = dictionary.IndexOf(del, index);
                string wordD = dictionary.Substring(index, indexEnd - index);
                words.Add(wordD);
                dictionary = dictionary.Remove(index, indexEnd - index + del.Length);
                definitions.Add(dictionary);
                index = 0;
            }
        }
        for (int i = 0; i < words.Count; i++)
        {
            if (word == words[i])
            {
                Console.WriteLine(definitions[i]);
            }
        }
    }
}

