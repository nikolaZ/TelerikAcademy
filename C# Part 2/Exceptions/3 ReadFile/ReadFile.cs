//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.
using System;
using System.IO;
using System.Security;

    class ReadFile
    {
        static void Main()
        {
            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();
            try
            {
                FileRead(path);
                Console.WriteLine(FileRead(path));
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
            catch(NotSupportedException)
            {
                Console.WriteLine("Entered path file is NOT in right format!");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Entered path file is NOT in your permission!");
            }
            
        }
        static string FileRead(string path)
        {
            string content=File.ReadAllText(path);
            return content;
        }
    }

