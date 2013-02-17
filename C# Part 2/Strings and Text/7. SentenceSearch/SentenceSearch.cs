//Write a program that extracts from a given text all sentences containing given word.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Sentence
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string search = "in";
            Search(text, search);
        }
        static void Search(string text,string search)
        {
            string searchEnd = ".";
            text = text.ToLower();
            int index = 0;
            int indexStart = 0;
            List<string> sentences=new List<string>();
            while (text.IndexOf(searchEnd, index) > 0)
            {
                int indexEnd = text.IndexOf(searchEnd, index);
                string sentence = text.Substring(indexStart, indexEnd+1 -indexStart );
                sentences.Add(sentence.Trim());
                indexStart = indexEnd+1;
                index = indexEnd +1;
            }
            //foreach (var item in sentences)
            //{
            //    Console.WriteLine(item);
            //}
            StringBuilder case1 = new StringBuilder();
            case1.Append(" ");
            case1.Append(search);
            case1.Append(" ");
            StringBuilder case2 = new StringBuilder();
            case2.Append(".");
            case2.Append(search);
            case2.Append(" ");
            StringBuilder case3 = new StringBuilder();
            case3.Append(" ");
            case3.Append(search);
            case3.Append(".");
            for (int i = 0; i < sentences.Count; i++)
            {
                if (sentences[i].IndexOf(case1.ToString(),0)>0)
                {
                    Console.WriteLine(sentences[i]);
                }
                if (sentences[i].IndexOf(case2.ToString(), 0) > 0)
                {
                    Console.WriteLine(sentences[i]);
                }
                if (sentences[i].IndexOf(case3.ToString(), 0) > 0)
                {
                    Console.WriteLine(sentences[i]);
                }
            }
        }
    }

