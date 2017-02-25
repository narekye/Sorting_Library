using System;
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


    }
}
