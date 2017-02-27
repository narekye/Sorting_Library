using System;
using static System.Console;
namespace Binary_Search
{
    class BinaryArray
    {
        private int[] data;
        private Random generator = new Random();
        // Constructor
        public BinaryArray(int size)
        {

            data = new int[size];
            for (int j = 0; j < data.Length; j++)
            {
                data[j] = generator.Next(10, 100);
            }

        }

        // Binary search perform.
        public int BinarySearch(int searchElement)
        {
            int low = 0, high = data.Length - 1, middle = (low + high) / 2, location = -1;
            do
            {
                Write(RemainingElements(low, high));
                WriteLine(new string('-', 40));
                if (searchElement == data[middle])
                {
                    location = middle;
                }
                else if (searchElement < data[middle])
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
                middle = (low + high + 1) / 2;

            } while ((low <= high) && (location == -1));

            return location;
        }
        // shows which count elements remaining.
        public string RemainingElements(int low, int high)
        {
            string temporary = string.Empty;
            // output spaces alignment
            for (int i = 0; i < low; i++)
            {
                temporary += "    ";
            }

            // output elements left in array 
            for (int i = low; i <= high; i++)
            {
                temporary += data[i] + " ";
            }
            temporary += "\n";
            return temporary;
        }

    }
}
