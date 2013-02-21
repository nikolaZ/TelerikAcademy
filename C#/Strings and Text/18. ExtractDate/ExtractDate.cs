//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

    class ExtractDate
    {
        static void Main()
        {
            string text = "Краен срок: 23:59 часа на 31.01.2013.2	 Видео - 22.01.2013.";
            Extract(text);
        }
        static void Extract(string text)
        {
            foreach (var item in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
            {
                DateTime date = DateTime.ParseExact(item.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }

