using System;
using System.Xml.Linq;

class Program
{
    static int[] array = { 12, 2, 5, 6, 77, 34, 78 };
    static void Main()
    {
        Console.WriteLine("Original array: " + string.Join(",", array));

        var len = array.Length;
        for (var i = 1; i < len; i++)
        {
            for (var j = 0; j < len - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        Console.WriteLine("Sorted array: " + string.Join(",", array));

    }
    private static void Swap(ref int e1, ref int e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }
}