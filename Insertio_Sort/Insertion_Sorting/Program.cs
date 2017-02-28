using System;
using System.Collections.Generic;
namespace Insertion_Sorting
{
    class Program
    {
        static void Main()
        {
            // Perform insertion sorting example on generic method.
            // Just for example :)
            int[] array = { 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 3, 4, 4, 5, 5, 56434, 5423, 423423, 4, 234, 234, 545, 343 };
            PerformInsertionSort(array);
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }

        static T[] PerformInsertionSort<T>(T[] inputarray, Comparer<T> comparer = null)
        {
            var equalityComparer = comparer ?? Comparer<T>.Default;
            for (int counter = 0; counter < inputarray.Length - 1; counter++)
            {
                int index = counter + 1;
                while (index > 0)
                {
                    // if we change the statement to .... < 0 it will sorted by descending.
                    if (equalityComparer.Compare(inputarray[index - 1], inputarray[index]) > 0)
                    {
                        var temp = inputarray[index - 1];
                        inputarray[index - 1] = inputarray[index];
                        inputarray[index] = temp;
                    }
                    index--;
                }
            }
            return inputarray;
        }
    }
}
