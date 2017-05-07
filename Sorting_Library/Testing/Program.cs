using System;
using Sorting_Library;

namespace Testing
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 1, 3, 4, 6, 2, 3, 1, 4, 4 };
            arr.PerformBubbleSort();
            arr.PerformSelectionSort();
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
