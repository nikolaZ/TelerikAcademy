//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CorrectExpressionBrackets
    {
        static void Main()
        {
            string expression = "((a+b)/5-d)";
            ExpressionBrackets(expression);

        }
        static void ExpressionBrackets(string expression)
        {
            char[] evaluate = expression.ToCharArray();
            int counter = 1;
            bool result=true;
            for (int i = 0 ; i < expression.Length&&counter>0; i++)
            {
                if (expression[i]=='(')
                {
                    counter++;
                }
                else if (expression[i]==')')
                {
                    counter--;
                }
            }
            if (counter!=1)
            {
                result = false;
            }
            Console.WriteLine("The expression is correct: {0}",result);
        }
    }

