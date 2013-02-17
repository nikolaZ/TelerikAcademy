//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuickSort
{
    static void Main()
    {
        string[] str = { "adsdsa", "aadwe","erwer","gotorow","qwerty" ,"zxcvb","yawn","a",
                           "ftrete", "test", "aa", "net", "db", "it", "itsg", "gsaa", "gstaa"};
        List<string> unsortedList = str.ToList();
        unsortedList = QuickSorting(unsortedList);
        PrintResult(unsortedList);
    }
    static List<string> QuickSorting(List<string> listsort)
    {
        List<string> smaller = new List<string>();
        List<string> bigger = new List<string>();

        if (listsort.Count > 1)
        {
            int pivot = Pivot(listsort);
            string pivotSafe = listsort[pivot];
            for (int i = 0; i < listsort.Count; i++)
            {
                if (pivot != i)
                {
                    if (string.Compare(listsort[pivot], listsort[i]) >= 0)
                    {
                        smaller.Add(listsort[i]);
                    }
                    else
                    {
                        bigger.Add(listsort[i]);
                    }
                }
            }
            smaller = QuickSorting(smaller);
            bigger = QuickSorting(bigger);

            listsort.Clear();
            listsort.AddRange(smaller);
            listsort.Add(pivotSafe);
            listsort.AddRange(bigger);
        }

        return listsort;
    }
    static int Pivot(List<string> pivotList)
    {
        Random random = new Random();
        int getPivot = random.Next(pivotList.Count);
        return getPivot;
    }
    static void PrintResult(List<string> print)
    {
        foreach (string item in print)
        {
            Console.WriteLine(item);
        }
    }
}

