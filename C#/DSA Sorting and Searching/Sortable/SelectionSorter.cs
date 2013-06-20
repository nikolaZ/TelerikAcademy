namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            int length = collection.Count;
            int minValueIndex;
            T minValue;

            for (int i = 0; i < length - 1; i++)
            {
                minValue = collection[i];
                minValueIndex = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (collection[j].CompareTo(minValue) == -1)
                    {
                        minValue = collection[j];
                        minValueIndex = j;
                    }
                }

                if (!minValue.Equals(collection[i]))
                {
                    T safe = collection[i];
                    collection[i] = minValue;
                    collection[minValueIndex] = safe;
                }
            }
        }
    }
}
