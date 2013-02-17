//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumbers
{
    static void Main()
    {
        List<int> intList = new List<int>();
        for (int add = 0; add <= 10000000; add++)
        {
            intList.Add(add);
        }
        for (int i = 2; i < intList.Count - 1; i++)
        {
            if (intList[i] != 0)
            {
                for (int j = i + i; j < intList.Count - 1; j += i)
                {
                    intList[j] = 0;
                }
                Console.WriteLine(intList[i]);// Here could be used Console.Write with a space string for faster printing.
            }
        }
        //This solution is by using again list but here first the list is populated and then
        //all not prime numbers are removed from the list.Then the remaining numbers are printed.
        //However, this solution is by far slower than the first one because first we calculate then we print.
        //
        //List<int> intList = new List<int>(); 
        //for (int add = 0; add <= 10000000; add++)
        //{
        //    intList.Add(add);
        //}
        //for (int i = 2; i < 10000000; i++)
        //{
        //        for (int j = i + i; j < 10000000; j += i)
        //        {
        //            intList.Remove(j);
        //        }
        //        //Console.WriteLine(intList[i]);
        //    }
        //intList.TrimExcess();
        //foreach (var item in intList)
        //{
        //    Console.WriteLine(item);
        //}
        //}


    }
}


