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
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber > -5)
            {
                Console.WriteLine("It's warm");
                return;
            }
            if (inputNumber <= -5 && inputNumber > -20)
            {
                Console.WriteLine("It's okay");
                return;
            }
            if (inputNumber <= -20)
            {
                Console.WriteLine("It's cold");
                return;
            }
        }

    }
}





