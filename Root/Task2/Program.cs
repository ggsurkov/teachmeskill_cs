using System;
using System.Linq.Expressions;
using System.Xml.Serialization;
using ErrorExeptionsLib;
namespace Task2
{
    internal sealed class Program
    {
        private static void Main()
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (ErrorExeptionsLib.ErrorExeptionsService.isCorrectIntMonthValue(inputNumber))
            {
                if (inputNumber == 1)
                {
                    Console.WriteLine("January");
                } 
                else if (inputNumber == 2)
                {
                    Console.WriteLine("February");
                }
                else if (inputNumber == 3)
                {
                    Console.WriteLine("Marth");
                }
                else if (inputNumber == 4)
                {
                    Console.WriteLine("April");
                }
                else if (inputNumber == 5)
                {
                    Console.WriteLine("May");
                }
                else if (inputNumber == 6)
                {
                    Console.WriteLine("June");
                }
                else if (inputNumber == 7)
                {
                    Console.WriteLine("July");
                }
                else if (inputNumber == 8)
                {
                    Console.WriteLine("August");
                }
                else if (inputNumber == 9)
                {
                    Console.WriteLine("September");
                }
                else if (inputNumber == 10)
                {
                    Console.WriteLine("October");
                }
                else if (inputNumber == 11)
                {
                    Console.WriteLine("November");
                }
                else if (inputNumber == 12)
                {
                    Console.WriteLine("December");
                }
                else 
                { 
                    Console.WriteLine("Something went wrong. Please, try again"); 
                }
            }

        }

    }
}





