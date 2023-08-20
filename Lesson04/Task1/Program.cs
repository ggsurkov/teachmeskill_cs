using System;

namespace Solution
{
    static class Task1
    {
        private static void Main()
        {
            int[] arr1 = { 3, 5, 1, 9, 15, 11, -17 };

            Console.WriteLine(findHighestNumberFromArray(arr1));
        }

        public static int findHighestNumberFromArray(int[] array) 
        {
            int result = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] > result)
                    result = array[index];
            }
            return result;
        }
    }
}