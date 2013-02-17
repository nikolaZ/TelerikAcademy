//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordsReplace
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbidden = "Microsoft,PHP,CLR";
        Replace(text, forbidden);
    }
    static void Replace(string text, string forbidden)
    {
        string searchEnd = ",";
        int index = 0;
        int indexStart = 0;
        List<string> words = new List<string>();
        while (forbidden.IndexOf(searchEnd, index) > 0)
        {
            int indexEnd = forbidden.IndexOf(searchEnd, index);
            string word = forbidden.Substring(indexStart, indexEnd - indexStart);
            words.Add(word.Trim());
            indexStart = indexEnd + 1;
            index = indexEnd + 1;
        }
        string lastWord = forbidden.Substring(index, forbidden.Length - index);
        words.Add(lastWord.Trim());
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
        for (int i = 0; i < words.Count; i++)
        {
            text = text.Replace(words[i], new string('*', words[i].Length));
        }
        Console.WriteLine(text);
    }
}

