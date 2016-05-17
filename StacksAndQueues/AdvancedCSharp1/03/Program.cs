using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main()
        {
            int[] inputNums = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            for (int i = 0; i < array.Length; i++)
            {
                stack.Push(array[i]);
            }

            for (int i = 0; i < inputNums[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(inputNums[2]))
            {
                Console.WriteLine("true");
            }
            else if (!stack.Contains(inputNums[2]) && stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
