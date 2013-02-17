//You are given an array of strings. Write a method that sorts the array
//by the length of its elements (the number of characters composing them).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class StringSort
    {
        static void Main()
        {
            string[,] matrix = new string[,]{
                {"adw","adwe","qw","a"},
                {"asdwee","awqqq","qwertyui","8765432100"},
                {"2344","qqww","12345tyu","aaa"}};
            Print(Sorting(ArrayPart(matrix)));
        }
        static List<string> ArrayPart(string[,] array)
        {
            List<string> list = new List<string>();
            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int cols = 0; cols < array.GetLength(1); cols++)
                {
                    list.Add(array[rows, cols]);
                }
            }
            return list;
        }
        static string[] Sorting(List<string> lists)
        {
            string[] array = lists.ToArray();
            Array.Sort(array, (a, b)=>(a.Length).CompareTo(b.Length));
            return array;
        }
        static void Print(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

