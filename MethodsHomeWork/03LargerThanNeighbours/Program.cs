using System;

namespace _03LargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            int[] numbers = {1, 3, 4, 5, 1, 0, 5};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        static bool IsLargerThanNeighbours(int [] numbers, int index)
        {
            if (index < 0 || index >= numbers.Length)
            {
                throw new ArgumentOutOfRangeException
                    ("The index can't be smaller than zero or equal or bigger than the length of the array");
            }

            if (index > 0 && index < numbers.Length - 1)
            {
                if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (index == 0)
            {
                if (numbers[index] > numbers[index + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (index == numbers.Length - 1)
            {
                if (numbers[index] > numbers[index - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
