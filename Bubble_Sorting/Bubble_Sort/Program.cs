using System;
using System.Collections.Specialized;
using System.Runtime.Remoting.Messaging;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 4, 5, 3, 4, 5, 6, 6, 76, 7, 78, 2, 5, 6, 7 };
            Bubble(ref a);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }

        public static void Bubble(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Exchange(ref int[] arr, int first, int end)
        {
            if (first > arr.Length || end > arr.Length)
            {
                Console.WriteLine("The sended parameters {0} and {1} are out of range", first, end);
                return;
            }
            int temp = arr[first];
            arr[first] = arr[end];
            arr[end] = temp;
        }

        #region Generate Random Array
        public static int[] RandomArray(int length)
        {
            Random rd = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(int.MinValue, int.MaxValue);
            }
            return arr;
        }

        public static void RandomArray(ref int[] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(int.MinValue, int.MaxValue);
            }
        }
        #endregion

    }
}
