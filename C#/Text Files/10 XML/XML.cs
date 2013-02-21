//Write a program that extracts from given XML file all the text without the tags.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class XML
{

    static void Main()
    {
        StreamReader input = new StreamReader(@"C:\input.txt");
        StreamWriter output = new StreamWriter(@"C:\output.txt");
        GetText(input, output);
    }
    static void GetText(StreamReader input, StreamWriter output)
    {
        List<string> text = new List<string>();
        string content = string.Empty;
        int startIndex = 0;
        int length = 0;
        using (input)
        {
            content = input.ReadToEnd();
        }
        for (int search = 0; search != -1; startIndex = search + 1,length = 0)
        {
            search = content.IndexOf('>', startIndex);
            if (search == -1)
            {
                break;
            }
            startIndex = search + 1;
            search = content.IndexOf('<', startIndex); 
            if (search == -1)
            {
                break;
            }
            if (search - startIndex > 1)
            {
                length = search - startIndex; 
                text.Add(content.Substring(startIndex, length));
            }
        }
        using (output)
        {
            foreach (string line in text)
            {
                output.WriteLine(line);
            }
        }
    }
}



