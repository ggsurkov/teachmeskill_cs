using System;
using System.Reflection;

namespace Calculator
{
    class Task4
    {
        static string errorMessage = "Something went wrong. Please to repeat the insert";

        private static void Main()
        {
            string inner = Console.ReadLine();
            int res = calc(inner);
            while (res == 0)
            {
                Console.WriteLine(errorMessage); ;
                inner = Console.ReadLine();
                res = calc(inner);
            }

            Console.WriteLine(res.ToString());

        }

        private static int calc(string inner)
        {
            int result = 0;

            if (inner.ToLower().Contains('+')) 
            { 
                string[] innerArray = inner.Split('+');

                foreach (var x in innerArray)
                {
                    result = result + Int16.Parse(x);
                }

                return result;
            }
            if (inner.ToLower().Contains('-'))
            {
                string[] innerArray = inner.Split('-');
                result = Int16.Parse(innerArray[0]) - Int16.Parse(innerArray[1]);
                return result;
            }
            if (inner.ToLower().Contains('*'))
            {
                string[] innerArray = inner.Split('*');

                result = Int16.Parse(innerArray[0]) * Int16.Parse(innerArray[1]);
                return result;
            }
            if (inner.ToLower().Contains('/'))
            {
                string[] innerArray = inner.Split('/');
                if (Int16.Parse(innerArray[1]) == 0)
                {
                    return 0;
                }
                result = Int16.Parse(innerArray[0]) / Int16.Parse(innerArray[1]);
                return result;
            }

            return result;
        }
    }
}