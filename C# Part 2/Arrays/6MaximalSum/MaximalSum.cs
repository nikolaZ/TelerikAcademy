//Write a program that reads two integer numbers N and K and
//an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaximalSum
    {
        static void Main()
        {
            //int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int safe = 0;
            int cont = 0;
            int result = 0;
            List<int> intList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                intList.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < intList.Count-1; j++)
                {
                    if (intList[j] > intList[j + 1])
                    {
                        if (intList[j] > safe)
                        {
                            safe = intList[j];
                            cont = j;
                        }
                        
                    }
                    else
                    {
                        if (intList[j + 1] > safe)
                        {
                            safe = intList[j+1];
                            cont = j + 1;
                        }
                    }
                }
                intList.Remove(intList[cont]);
                result += safe;
                safe = 0;
            } Console.WriteLine(result);
        }
    }

