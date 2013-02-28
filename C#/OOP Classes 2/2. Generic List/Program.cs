using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>(1);
            test.Add(2);
            test.Add(45);
            test.Add(4);
            test.Add(50);
            test.Add(0);
            test.Add(-1000);

            Console.WriteLine(test);

            test.Remove(4);

            Console.WriteLine(test);

            test.Insert(0, 560);

            Console.WriteLine(test);

            Console.WriteLine(test.Find(123));


            Console.WriteLine(test.Max());
            Console.WriteLine(test.Min());

            test.Clear();

            Console.WriteLine(test);
        }
    }
}
