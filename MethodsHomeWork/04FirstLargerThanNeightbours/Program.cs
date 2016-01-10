using System;

namespace _04FirstLargerThanNeightbours
{
    class Program
    {
        static void Main()
        {
            int[] sequenceOne = {1, 3, 4, 5, 1, 0, 5};
            int[] sequenceTwo = {1, 2, 3, 4, 5, 6, 6};
            int[] sequenceThree = {1, 1, 1};

            Console.WriteLine(GetFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetFirstElementLargerThanNeighbours(sequenceThree));
        }

        static int GetFirstElementLargerThanNeighbours(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        return i;
                    }
                }

                if (i > 0 && i < array.Length - 1)
                {
                    if (array[i] > array[i + 1] && array[i] > array[i - 1])
                    {
                        return i;
                    }
                }

                if (i == array.Length - 1)
                {
                    if (array[i] > array[i - 1])
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
