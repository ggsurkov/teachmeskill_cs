using System;

namespace Solution
{
    static class Task3
    {
        private static void Main()
        {
            int n = 12;

            int[] result = collectFibonachyRowByLengthOfRow(n);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] collectFibonachyRowByLengthOfRow(int finbonachyLength)
        {
            int[] result = new int[finbonachyLength];

            for(int i = 0; i < finbonachyLength; i++)
            {
                if (i == 0)
                {
                    result[i] = 0;
                }
                else if (i == 1)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = result[i - 1] + result[i - 2];
                }
            }

            return result;
        }
    }
}