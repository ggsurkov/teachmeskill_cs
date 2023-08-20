using System;

namespace Solution
{
    static class Task2
    {
        private static void Main()
        {
            int[][] arr1 = new int[3][];
            arr1[0] = new int[2] { 1, 32 };
            arr1[1] = new int[3] { 3, 4, 35 };
            arr1[2] = new int[4] { 6, 7, 8, 39 };

            Console.WriteLine(findAvarage(arr1));
        }

        public static double findAvarage(int[][] array)
        {
            int sum = 0;
            foreach(int[] row in array)
            {
                foreach(int x in row)
                {
                    sum += x;
                }
            }
            
            return sum / array.Length;
        }
    }
}