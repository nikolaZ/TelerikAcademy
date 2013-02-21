//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class URLAdress
    {
        static void Main()
        {
            string adress = @"http://www.devbg.org/forum/index.php ";
            Extract(adress);
        }
        static void Extract(string adress)
        {
            string symbols = "://";
            adress = adress.ToLower();
            int index = 0;
            int count = 0;
            while (adress.IndexOf(symbols, index) > 0)
            {
                int indexEnd = adress.IndexOf(symbols, index);
                string server = adress.Substring(index, indexEnd - index);
                Console.WriteLine(server);
                adress=adress.Remove(index, indexEnd - index + symbols.Length);
                symbols = "/";
                index = 0;
                count++;
                if (count>=2)
                {
                    break;
                }
            }
            Console.WriteLine(adress);

        }
    }

