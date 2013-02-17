//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Security;

    class FilesWord
    {
        static void Main()
        {
            StreamReader input = new StreamReader(@"C:\input.txt");
            StreamReader output = new StreamReader(@"C:\output.txt");
            StreamWriter result = new StreamWriter(@"C:\result.txt");
            try
            {
                List<string> list = GetWords(input);
                string clear = string.Empty;
                using (output)
                {
                    using (result)
                    {
                        while (true)
                        {
                            string line = output.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            for (int i = 0; i < list.Count; i++)
                            {
                                string word = list[i];
                                line = line.Replace(word, clear);
                            } result.WriteLine(line);

                        }
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
        static List<string> GetWords(StreamReader input)
        {
            List<string> list = new List<string>();
            using (input)
            {
                while (true)
                {
                   string word = input.ReadLine();
                    if (word==null)
                    {
                        break;
                    }
                    list.Add(word);
                }
            }
            return list;
        }
    }

