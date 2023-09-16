using CourseWork01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork01.Utilities
{
    internal class JsonLogger : ILogger
    {
        private readonly string _jsonFilepath = "TodoList_info.json";

        public void Log(string message)
        {
            File.AppendAllText(_jsonFilepath, message);
        }
    }
}
