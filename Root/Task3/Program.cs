using System;
using System.Linq.Expressions;
using System.Xml.Serialization;
using ErrorExeptionsLib;
namespace Task3
{
    internal sealed class Program
    {
        private static void Main()
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber <= 0)
            {
                Console.WriteLine("Insert is wrong. Please, write the number above than 0");
                return;
            }
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }

    }
}





