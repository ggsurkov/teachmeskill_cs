using System;
using System.Linq.Expressions;
using ErrorExeptionsLib;
namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            dynamic insertedValue = Console.ReadLine();
            int.TryParse(insertedValue, out int inputNumber);
            if (ErrorExeptionsLib.ErrorExeptionsService.IsCorrectIntMonthValue(inputNumber))
            {
                switch (inputNumber)
                {
                    case 1:
                        Console.WriteLine("Winter");
                        break;
                    case 2:
                        Console.WriteLine("Winter");
                        break;
                    case 3:
                        Console.WriteLine("Spring");
                        break;
                    case 4:
                        Console.WriteLine("Spring");
                        break;
                    case 5:
                        Console.WriteLine("Spring");
                        break;
                    case 6:
                        Console.WriteLine("Summer");
                        break;
                    case 7:
                        Console.WriteLine("Summer");
                        break;
                    case 8:
                        Console.WriteLine("Summer");
                        break;
                    case 9:
                        Console.WriteLine("Autumn");
                        break;
                    case 10:
                        Console.WriteLine("Autumn");
                        break;
                    case 11:
                        Console.WriteLine("Autumn");
                        break;
                    case 12:
                        Console.WriteLine("Winter");
                        break;

                    default:
                        Console.WriteLine("Something went wrong. Please, try again");
                        break;
                }
            }
            
        }

    }
}





