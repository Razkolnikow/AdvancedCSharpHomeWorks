using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ReverseNumsWithStack
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
