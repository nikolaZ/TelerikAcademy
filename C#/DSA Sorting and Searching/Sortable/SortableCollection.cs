namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.Items[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            this.Sort(new MergeSorter<T>());

            int startIndex = 0;
            int endIndex = this.Items.Count - 1;

            while (startIndex <= endIndex)
            {
                int middleIndex = (startIndex + endIndex) / 2;

                if (item.CompareTo(this.items[middleIndex]) < 0)
                {
                    endIndex = middleIndex - 1;
                }
                else if (item.CompareTo(this.items[middleIndex]) > 0)
                {
                    startIndex = middleIndex + 1;
                }
                else // value found
                {
                    return true;
                }
            }

            return false;
        }

        public void Shuffle()
        {
            Random rnd = new Random();

            int length = this.Items.Count;

            for (int i = 0; i < length; i++)
            {
                int rndIndex = i + rnd.Next(0, length - i);
                T safe = this.Items[i];
                this.Items[i] = this.Items[rndIndex];
                this.Items[rndIndex] = safe;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
