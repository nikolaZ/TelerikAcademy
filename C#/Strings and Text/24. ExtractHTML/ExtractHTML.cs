//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

    class ExtractHTML
    {
        static void Main()
        {
            string text = @"<html><head><title>News</title></head><body><p><a href=\""http://academy.telerik.com\"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            Extract(text);
        }
        static void Extract(string text)
        {
            foreach (Match content in Regex.Matches(text, "(?<=>).*?(?=<)"))
            {
                Console.WriteLine(content);
            }
        }
    }

