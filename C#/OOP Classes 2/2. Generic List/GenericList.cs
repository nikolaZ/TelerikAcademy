using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class GenericList<T>// where T: IComparable
    {
        private T[] List;
        private int capacity;

        public T this[int index]
        {
            get
            {
                if (index > 0 && index <= capacity)
                {
                    return List[index];
                }
                else
                {
                    throw new ArgumentException("Index out f range");
                }
                
            }
            set { List[index] = value; }
        }

        public GenericList(int size)
        {
            if (size > 0)
            {
                List = new T[size];
            }
            else { throw new ArgumentException("List capacity must be positive"); }
        }
        public T Max()
        {
            if (List.Count()==0)
            {
                throw new ArgumentNullException("Empty List");
            }
            else
            {
                T max = List[0];
                for (int i = 1; i < List.Count(); i++)
                {
                    if ((List[i] as IComparable).CompareTo(max as IComparable)>0)
                    {
                        max = List[i];
                    }
                }
                return max;
            }

        }
        public T Min()
        {
            if (List.Count() == 0)
            {
                throw new ArgumentNullException("Empty List");
            }
            else if (List[0] is IComparable)
            {
                T min = List[0];
                for (int i = 1; i < List.Count(); i++)
                {
                    if ((List[i] as IComparable).CompareTo(min as IComparable) < 0)
                    {
                        min = List[i];
                    }
                }
                return min;
            }
            else { throw new FormatException("Items cannot be compared"); }
        }
        public void Add(T element)
        {
            if (capacity>= List.Length)
            {
                Autogrow();
            }
                List[capacity] = element;
                capacity++;
        }
        public void Remove(int index)
        {
            if (index > 0 && index < List.Count())
            {
                T[] tempList = new T[List.Count() - 1];
                for (int i = 0; i < index; i++)
                {
                    tempList[i] = List[i];
                }
                for (int i = index; i < List.Count()-1; i++)//////////
                {
                    tempList[i] = List[i + 1];
                }
                List = tempList;
            }
            else
            {
                throw new ArgumentException("Index outside the boundaries");
            }
        }

        public void Insert(int index, T element)
        {
            if (index >= 0 && index <= List.Count())
            {
                T[] tempList = new T[List.Count() + 1];
                for (int i = 0; i < index; i++)
                {
                    tempList[i] = List[i];
                }
                tempList[index] = element;
                for (int i = index+1; i < List.Count(); i++)
                {
 
                    tempList[i] = List[i-1];
                }
                List = tempList;
            }
            else
            {
                throw new ArgumentException("Index outside the boundaries");
            }
        }
        public int Find(T value)
        {
            int index = -1;
            for (int i = 0; i < List.Count(); i++)
            {
                if (List[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void Clear()
        {
            T[] tempList = new T[List.Length];
            List = tempList;
        }
        private void Autogrow()
        {
            T[] tempList = new T[List.Length * 2];
            for (int i = 0; i < List.Length; i++)
            {
                tempList[i] = List[i];
            }
            List = tempList;
        }
        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            foreach (var element in List)
            {
                print.AppendFormat("{0} | ", element);
            }
            return print.ToString();
        }
    }

