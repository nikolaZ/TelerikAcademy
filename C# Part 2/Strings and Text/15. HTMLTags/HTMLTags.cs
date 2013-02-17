//Write a program that replaces in a HTML document given 
//as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HTMLTags
    {
        static void Main()
        {
            string html = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            Console.WriteLine(Extract(html));
        }
        static string Extract(string html)
        {
            string[] toEscape = new string[] { "<a href=\"","\">" ,"</a>"};
            string[] toReplace = new string[] { "[URL=", "]", "[/URL]" };
            for (int i = 0; i < toEscape.Length; i++)
            {
                html = html.Replace(toEscape[i], toReplace[i]);
            }
            return html;
        }
    }

