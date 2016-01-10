using System;
using System.Collections.Generic;
using System.Linq;

namespace _07GenericArraySort
{
    class Program
    {
        static void Main()
        {
            int[] numbers = {1, 3, 4, 5, 1, 0, 5};
            string[] strings = {"zaz", "cba", "baa", "azis"};
            DateTime[] dates =
            {
                new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1),   
            };

            SortArray(numbers);
            Console.WriteLine(string.Join(", ", numbers));
            SortArray(strings);
            Console.WriteLine(string.Join(", ", strings));
            SortArray(dates);
            Console.WriteLine(string.Join(", ", dates));
        }

        static void SortArray<T> (T[] array) 
            where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                T min = array[i];
                int index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(min) == -1)
                    {
                        min = array[j];
                        index = j;
                    }
                }

                array[index] = array[i];
                array[i] = min;
            }
        }
    }
}
