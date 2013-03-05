using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            try
            {
            string temp = builder.ToString(index, length);
            builder.Clear();
            builder.Append(temp);
            return builder;
            }
            catch (ArgumentOutOfRangeException)
            {
                return new StringBuilder("Index and/or substring length are outside the string borders!");
            }       
        }
        public static StringBuilder Substring(this StringBuilder builder, int index)
        {
            return new StringBuilder(builder.ToString(index, builder.Length - index));
        }

    }

