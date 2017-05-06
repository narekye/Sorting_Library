using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort_Exampe_Uses_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 7, 8, 10, 6, 5 };
            MergeSort(array);
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
        }


    }
}
