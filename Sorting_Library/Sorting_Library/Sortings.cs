namespace Sorting_Library
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Perform own sorting algorithm with extension methods
    /// Generic types included to all algorithms.
    /// </summary>
    public static class Sortings
    {
        /// <summary>
        /// Bubble Sorting, best and worst cases pasted in text below for Big - O <para />
        /// Hardest: O(n) , O(n^2) , O(n^2) <para />
        /// Memory: O(1) , O(1) , O(1) <para />
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns>void</returns>
        #region Bubble
        public static void PerformBubbleSort<T>(this T[] array)
        {
            var equalityComparer = Comparer<T>.Default;
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
            Comparer<T> comparer = Comparer<T>.Default;
            if (comparer.Compare(x, y) == 0) return;
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion Bubble

        /// <summary>
        /// Insertion Sorting, best and worst cases pasted in text below for Big - O <para />
        /// Hardest: O(n) , O(n^2) , O(n^2) <para />
        /// Memory: O(1) , O(1) , O(1) <para />
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns>void</returns>
        #region Insertion
        public static void PerformInsertionSort<T>(this T[] array, Comparer<T> comparer = null)
        {
            var equalityComparer = comparer ?? Comparer<T>.Default;
            for (int counter = 0; counter < array.Length - 1; counter++)
            {
                int index = counter + 1;
                while (index > 0)
                {
                    // if we change the statement to .... < 0 it will sorted by descending.
                    if (equalityComparer.Compare(array[index - 1], array[index]) > 0)
                    {
                        T temp = array[index - 1];
                        array[index - 1] = array[index];
                        array[index] = temp;
                    }
                    index--;
                }
            }
        }
        #endregion

        /// <summary>
        /// Merge Sorting, best and worst cases pasted in text below for Big - O <para />
        /// Using recursion for cutting the array to subarrays. <para />
        /// Hardest: O(n log n) , O(n log n) , O(n log n) <para />
        /// Memory: O(n) , O(n) , O(n) <para />
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns>void</returns>
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

        /// <summary>
        /// Selection Sorting, best and worst cases pasted in text below for Big - O <para />
        /// Hardest: O(n) , O(n^2) , O(n^2) <para />
        /// Memory: O(1) , O(1) , O(1) <para />
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns>void</returns>
        #region Selection
        public static void PerformSelectionSort<T>(this T[] array)
        {
            int sortedRangeEnd = 0;
            while (sortedRangeEnd < array.Length)
            {
                int nextSmallestIndex = FindIndex(array, sortedRangeEnd);
                Swap(array, sortedRangeEnd, nextSmallestIndex);
                sortedRangeEnd++;
            }
        }

        private static void Swap<T>(T[] array, int left, int right)
        {
            if (left == right) return;
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;

        }
        private static int FindIndex<T>(T[] array, int index)
        {
            Comparer<T> equality = Comparer<T>.Default;
            T current = array[index];
            int currentindex = index;
            for (int i = index + 1; i < array.Length; i++)
            {
                if (equality.Compare(current, array[i]) > 0)
                {
                    current = array[i];
                    currentindex = i;
                }
            }
            return currentindex;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        #region Quick
        public static void PerformQuickSort<T>(this T[] array) { }
        #endregion
    }
}
