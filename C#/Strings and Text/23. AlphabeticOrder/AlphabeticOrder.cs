//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class AlphabeticOrder
    {
        static void Main()
        {
            string towns = "Sofia Varna Plovdiv Pleven Bourgas Rousse Yambol Karlovo";
            string[] words = towns.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            StringBuilder result = new StringBuilder();
            foreach (var town in words)
            {
                result.Append(town);
                result.Append(" ");
            }
            Console.WriteLine(result.ToString());
        }
    }

