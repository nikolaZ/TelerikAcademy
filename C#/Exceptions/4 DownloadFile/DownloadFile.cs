//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.Net;

    class DownloadFile
    {
        static void Main()
        {
            try
            {
                DownLoad();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Adress is null.");
            }
            catch (WebException)
            {
                Console.WriteLine("An error occurred while downloading data.Check adress/filename/connection.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Sorry, an error occured during processing.");
            }
        }
        static void DownLoad()
        {
            WebClient web = new WebClient();
            using (web)
            {
                web.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg",@"D:\logoBASD.jpg");
            }
        }
    }

