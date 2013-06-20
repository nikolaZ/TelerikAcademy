namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "Collection is null. Collection cannot be sorted!");
            }

            int length = collection.Count;
            if (length <= 1)
            {
                return;
            }

            IList<T> sorted = this.QuickSorting(collection);

            collection.Clear();
            foreach (T item in sorted)
            {
                collection.Add(item);
            }
        }

        private IList<T> QuickSorting(IList<T> collection)
        {
            int length = collection.Count;
            if (length > 1)
            {
                int pivotIndex = length / 2;
                T pivot = collection[pivotIndex];

                collection.RemoveAt(pivotIndex);

                IList<T> greater = new List<T>();
                IList<T> smallerAndEqual = new List<T>();

                foreach (T element in collection)
                {
                    if (element.CompareTo(pivot) > 0)
                    {
                        greater.Add(element);
                    }
                    else
                    {
                        smallerAndEqual.Add(element);
                    }
                }

                greater = QuickSorting(greater);
                smallerAndEqual = QuickSorting(smallerAndEqual);

                collection = this.Concatenate(smallerAndEqual, pivot, greater);
            }

            return collection;
        }

        private IList<T> Concatenate(IList<T> smallerAndEqual, T pivot, IList<T> greater)
        {
            List<T> result = new List<T>();

            result.AddRange(smallerAndEqual);
            result.Add(pivot);
            result.AddRange(greater);

            return result;
        }
    }
}
