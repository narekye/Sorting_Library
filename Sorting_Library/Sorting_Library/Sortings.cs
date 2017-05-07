using System;
using System.Collections.Generic;

namespace Sorting_Library
{
    public static class Sortings
    {
        #region Bubble
        public static void PerformBubbleSort<T>(this T[] array, Comparer<T> comparer = null)
        {
            var equalityComparer = comparer ?? Comparer<T>.Default;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (equalityComparer.Compare(array[j], array[j + 1]) > 0) // array[j] > array[j + 1]
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion Bubble

        #region Insertion
        public static void PerformInsertionSort<T>(this T[] inputarray, Comparer<T> comparer = null)
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
                        T temp = inputarray[index - 1];
                        inputarray[index - 1] = inputarray[index];
                        inputarray[index] = temp;
                    }
                    index--;
                }
            }
        }
        #endregion

        #region Merge

        public static void PerformMergeSort<T>(this T[] array)
        {
            if (array.Length <= 1) return;

            int leftsize = array.Length / 2;
            int rightsize = array.Length - leftsize;

            T[] left = new T[leftsize];
            T[] right = new T[rightsize];

            Array.Copy(array, 0, left, 0, leftsize);
            Array.Copy(array, leftsize, right, 0, rightsize);

            PerformMergeSort(left);
            PerformMergeSort(right);

            Merge(array, left, right);
        }

        private static void Merge<T>(T[] array, T[] left, T[] right, Comparer<T> comparer = null)
        {
            var equalitycomparer = comparer ?? Comparer<T>.Default;
            int leftindex = 0, rigthindex = 0, target = 0;
            int remaining = left.Length + right.Length;

            while (remaining > 0)
            {
                if (leftindex >= left.Length)
                {
                    array[target] = right[rigthindex++];
                }
                else if (rigthindex >= right.Length)
                {
                    array[target] = left[leftindex++];
                }

                else if (equalitycomparer.Compare(left[leftindex], right[rigthindex]) < 0)
                {
                    array[target] = left[leftindex++];
                }
                else
                {
                    array[target] = right[rigthindex++];
                }

                target++;
                remaining--;
            }
        }
        #endregion
    }
}
