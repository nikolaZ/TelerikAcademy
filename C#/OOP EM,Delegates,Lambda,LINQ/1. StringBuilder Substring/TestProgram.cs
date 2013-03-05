//Implement an extension method Substring(int index, int length) for the class StringBuilder
//    that returns new StringBuilder and has the same functionality as Substring in the class String.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new StringBuilder("test StringBuilder").Substring(5, 6));
            StringBuilder testBuilder = new StringBuilder();
            testBuilder.Append("testBuilder");           
            Console.WriteLine(testBuilder.Substring(1));
        }
    }