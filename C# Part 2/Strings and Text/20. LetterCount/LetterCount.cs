//Write a program that reads a string from the console and prints all different letters 
//in the string along with information how many times each letter is found. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class LetterCount
    {
        static void Main()
        {
            string text = "ABBA lamal system box aaazzwww";
            Letters(text);
        }
        static void Letters(string text)
        {
            text = text.ToLower();
            int[] alphabet = new int[26];
            char start = 'a';
            char end = 'z';
            foreach (char letter in text)
            {
                if (start <= letter && letter <= end)
                { 
                    alphabet[letter - start]++; 
                }
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] != 0)
                {
                    Console.WriteLine("{0}: {1}", (char)(i + start), alphabet[i]);
                }
            }
        }
    }
