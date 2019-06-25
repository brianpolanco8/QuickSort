using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 5, 0, 34, 3, 9 };

            SortArray(numbers);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }

        private static void SortArray(int[] numbers)
        {
            QuickSort(numbers, 0, numbers.Length - 1);
        }

        private static void QuickSort(int[] numbers, int left, int right)
        {
            throw new NotImplementedException();
        }
    }
}
