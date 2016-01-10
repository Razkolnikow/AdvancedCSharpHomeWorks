using System;

namespace _06NumberCalculations
{
    class Program
    {
        static void Main()
        {
            double[] numbers = { 100, 54, 34.5, 1, -9 };

            Console.WriteLine("Min: " + GetMinNumber(numbers));
            Console.WriteLine("Max: " + GetMaxNumber(numbers));
            Console.WriteLine("Sum: " + GetSumOfNumbers(numbers));
            Console.WriteLine("Average: " + GetAverage(numbers));
            Console.WriteLine("Product: " + GetProduct(numbers));

            Console.WriteLine(string.Join(", ", numbers));
        }

        //Methods with double numbers
        static double[] SortArray(double[] numbers)
        {
            double[] workArray = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                workArray[i] = numbers[i];
            }
            for (int i = 0; i < workArray.Length - 1; i++)
            {
                double min = workArray[i];
                int index = i;
                for (int j = i + 1; j < workArray.Length; j++)
                {
                    if (workArray[j] < min)
                    {
                        min = workArray[j];
                        index = j;
                    }
                }

                workArray[index] = workArray[i];
                workArray[i] = min;
            }

            return workArray;
        }

        static double GetMinNumber(double[] numbers)
        {
            double[] workArray = SortArray(numbers);
            return workArray[0];
        }

        static double GetMaxNumber(double[] numbers)
        {
            double[] workArray = SortArray(numbers);
            return workArray[workArray.Length - 1];
        }

        static double GetSumOfNumbers(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static double GetAverage(double[] numbers)
        {
            double sum = GetSumOfNumbers(numbers);
            double average = sum/numbers.Length;
            return average;
        }

        static double GetProduct(double[] numbers)
        {
            double product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }

        //Methods with decimal numbers

        static decimal[] SortArray(decimal[] numbers)
        {
            decimal[] workArray = new decimal[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                workArray[i] = numbers[i];
            }
            for (int i = 0; i < workArray.Length - 1; i++)
            {
                decimal min = workArray[i];
                int index = i;
                for (int j = i + 1; j < workArray.Length; j++)
                {
                    if (workArray[j] < min)
                    {
                        min = workArray[j];
                        index = j;
                    }
                }

                workArray[index] = numbers[i];
                workArray[i] = min;
            }

            return workArray;
        }

        static decimal GetMinNumber(decimal[] numbers)
        {
            decimal[] workArray = SortArray(numbers);
            return workArray[0];
        }

        static decimal GetMaxNumber(decimal[] numbers)
        {
            decimal[] workArray = SortArray(numbers);
            return workArray[workArray.Length - 1];
        }

        static decimal GetSumOfNumbers(decimal[] numbers)
        {
            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static decimal GetAverage(decimal[] numbers)
        {
            decimal sum = GetSumOfNumbers(numbers);
            decimal average = sum / numbers.Length;
            return average;
        }

        static decimal GetProduct(decimal[] numbers)
        {
            decimal product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }
    }
}
