//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AlphabetLetters
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine().ToUpper();
        int[] alphabet = new int[27];
        int count = 1;
        for (int i = 65; i <= 90; i++)//26 Using ASCII Table
        {
            alphabet[count] = (char)i;
            count++;
        }
        foreach (var letter in word)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    Console.Write(i + " ");
                    break;
                }
            }
        }

    }
}

