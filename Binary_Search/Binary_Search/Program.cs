using System;
using static System.Console;

namespace Binary_Search
{
    class Program
    {
        static void Main()
        {
            int searchInt;
            int position;
            BinaryArray searchArray = new BinaryArray(15);
            searchInt = int.Parse(ReadLine());
            while (searchInt != -1)
            {
                // use binary search to try to find integer
                position = searchArray.BinarySearch(searchInt);

                // return value of -1 indicates integer was not found
                if (position == -1)
                {
                    WriteLine("The integer {0} was not found.\n", searchInt);
                }
                else
                {
                    WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);
                }

                // Prompt and input next int from user 
                WriteLine("Enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                WriteLine();

            }
        }
    }
}
