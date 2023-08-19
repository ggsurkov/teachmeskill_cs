using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLTest1
{
    
    public class Class1
    {
        public string _defaultMessage = "Default Message";
        public static void WriteInConsoleWithName(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
