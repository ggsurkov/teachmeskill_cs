using System;
using System.Linq.Expressions;
using ErrorExeptionsLib;
namespace Task2
{
    internal sealed class Program
    {
        private static void Main()
        {
            dynamic insertedValue = Console.ReadLine();
            int.TryParse(insertedValue, out int inputNumber);
            if (ErrorExeptionsLib.ErrorExeptionsService.IsCorrectIntMonthValue(inputNumber))
            {
                if (inputNumber == 1)
                {
                    Console.WriteLine("Winter");
                } 
                else if (inputNumber == 2)
                {
                    Console.WriteLine("Winter");
                }
                else if (inputNumber == 3)
                {
                    Console.WriteLine("Spring");
                }
                else if (inputNumber == 4)
                {
                    Console.WriteLine("Spring");
                }
                else if (inputNumber == 5)
                {
                    Console.WriteLine("Spring");
                }
                else if (inputNumber == 6)
                {
                    Console.WriteLine("Summer");
                }
                else if (inputNumber == 7)
                {
                    Console.WriteLine("Summer");
                }
                else if (inputNumber == 8)
                {
                    Console.WriteLine("Summer");
                }
                else if (inputNumber == 9)
                {
                    Console.WriteLine("Autumn");
                }
                else if (inputNumber == 10)
                {
                    Console.WriteLine("Autumn");
                }
                else if (inputNumber == 11)
                {
                    Console.WriteLine("Autumn");
                }
                else if (inputNumber == 12)
                {
                    Console.WriteLine("Winter");
                }
                else 
                { 
                    Console.WriteLine("Something went wrong. Please, try again"); 
                }
            }

        }

    }
}





