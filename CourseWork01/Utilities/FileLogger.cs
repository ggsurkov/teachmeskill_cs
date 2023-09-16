using CourseWork01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork01.Utilities
{
    internal class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public void Log(string message)
        {
            File.AppendAllText(_path, message);
        }
    }
}
