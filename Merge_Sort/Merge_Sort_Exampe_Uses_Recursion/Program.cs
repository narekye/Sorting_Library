using System;
using System.Diagnostics;

#pragma warning disable 219

namespace Merge_Sort_Exampe_Uses_Recursion
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10000];
            Random rd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(0, int.MaxValue);
            }
            Stopwatch timer = new Stopwatch();
            timer.Start();
            MergeSort(array);
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            Console.Read();
        }

        static void MergeSort(int[] array)
        {
            if (array.Length <= 1) return;

            int leftsize = array.Length / 2;
            int rightsize = array.Length - leftsize;

            int[] left = new int[leftsize];
            int[] right = new int[rightsize];

            Array.Copy(array, 0, left, 0, leftsize);
            Array.Copy(array, leftsize, right, 0, rightsize);

            MergeSort(left);
            MergeSort(right);

            Merge(array, left, right);
        }

        static void Merge(int[] array, int[] left, int[] right)
        {
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

                else if (left[leftindex].CompareTo(right[rigthindex]) < 0)
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
    }
}
