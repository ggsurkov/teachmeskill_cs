using System;
using System.Linq.Expressions;
using System.Xml.Serialization;
using ErrorExeptionsLib;
namespace Task4
{
    internal sealed class Program
    {
        private static void Main()
        {
            string insertedValue = Console.ReadLine();
            int.TryParse(insertedValue, out int inputNumber);
            if (inputNumber == null || inputNumber == 0 || inputNumber.GetType() != typeof(int))
            {
                Console.WriteLine("Insert is wrong. Please, write the number");
                return;
            }
            if (inputNumber > -5)
            {
                Console.WriteLine("It's warm");
                return;
            }
            if (inputNumber > -20)
            {
                Console.WriteLine("It's okay");
                return;
            }
            Console.WriteLine("It's cold");
        }

    }
}





