using System;
using System.Collections.Generic;

    public static class Extensions
    {
        public static T Min<T>(this IEnumerable<T> elements) where T:IComparable
        {
            dynamic min = long.MaxValue;
            foreach (var element in elements)
            {
                if (min>element)
                {
                    min = element;
                }
            }
            return min;

        }
        public static T Max<T>(this IEnumerable<T> elements) where T : IComparable
        {
            dynamic max = long.MinValue;
            foreach (var element in elements)
            {
                if (max<element)
                {
                    max = element;
                }
            }
            return max;
        }
        public static decimal Sum<T>(this IEnumerable<T> elements)
        {
            decimal sum = 0;
            foreach (var element in elements)
            {
                sum += Convert.ToDecimal(element);
            }
            return sum;
        }
        public static decimal Avg<T>(this IEnumerable<T> elements)
        {
            decimal average = Sum(elements);
            int counter = 0;
            foreach (var element in elements)
	        {
                counter++;
	        }
            return average/counter;
        }
        public static decimal Product<T>(this IEnumerable<T> elements)
        {
            decimal product = 1;
            foreach (var element in elements)
            {
                product *= Convert.ToDecimal(element);
            }
            return product;
        }
    }

