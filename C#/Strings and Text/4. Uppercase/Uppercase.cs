//You are given a text. Write a program that changes the text in all regions surrounded by
//the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//        The expected result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Uppercase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        ToUppercase(text);
    }
    static void ToUppercase(string text)
    {
        string searchStart = "<upcase>";
        string searchEnd = "</upcase>";
        text = text.ToLower();
        int index = 0;
        while (text.IndexOf(searchStart, index) > 0 && text.IndexOf(searchEnd, index) > 0)
        {
            int indexStart = text.IndexOf(searchStart, index);
            int indexEnd = text.IndexOf(searchEnd, index);
            string up = text.Substring(indexStart + 8, indexEnd - indexStart - 8);
            text = text.Remove(indexStart + 8, indexEnd - indexStart - 8);
            text = text.Insert(indexStart + 8, up.ToUpper());
            text = text.Remove(indexStart, 8);
            text = text.Remove(indexEnd - 8, 9);
            index = indexEnd - 7;//+8
        }
        Console.WriteLine(text);

    }
}

