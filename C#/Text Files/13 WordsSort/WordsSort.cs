//Write a program that reads a list of words from a file words.txt and finds how many times each of the words
//is contained in another file test.txt. The result should be written in the file result.txt 
//and the words should be sorted by the number of their occurrences in descending order. 
//Handle all possible exceptions in your methods.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security;

class WordsSort
{
    static void Main()
    {
        StreamReader input = new StreamReader(@"C:\words.txt");
        StreamReader output = new StreamReader(@"C:\test.txt");
        StreamWriter result = new StreamWriter(@"C:\result.txt");
        try
        {
            string[] list = GetWords(input);
            int[] counters = new int[list.Length];
            string clear = string.Empty;
            using (output)
            {
                while (true)
                {
                    string line = output.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    for (int i = 0; i < list.Length; i++)
                    {
                        int count = Regex.Matches(line, @"\b" + list[i] + @"\b").Count;
                        counters[i] += count;
                    }
                }
            }
            Array.Sort(counters, list);
            using (result)
            {
                for (int i = list.Length - 1; i >= 0; i--)
                {
                    result.WriteLine("{0}: {1}", list[i], counters[i]);
                }
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Entered path is empty!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Entered path is invalid - contains one or more invalid characters !");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Entered path, file name, or both is too long!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Entered path\'s directory is not found!Check directory/file path.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Entered path file is NOT found!Check file/file path.");
        }
        catch (IOException)
        {
            Console.WriteLine("Sorry, error occured while opening file!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Sorry,  You are NOT authorized to open path file !");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Entered path file is NOT in right format!");
        }
        catch (SecurityException)
        {
            Console.WriteLine("Entered path file is NOT in your permission!");
        }
    }
    static string[] GetWords(StreamReader input)
    {
        List<string> list = new List<string>();
        using (input)
        {
            while (true)
            {
                string word = input.ReadLine();
                if (word == null)
                {
                    break;
                }
                list.Add(word);
            }
        }
        return list.ToArray();
    }
}



