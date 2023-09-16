using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork01.Interfaces;

namespace CourseWork01.Services
{
    internal class TodoLineParserService
    {
        public string GetSecondCommand(string line)
        {
            return line.Split(" ")[1];
        }
        public string GetThirdCommand(string line)
        {
            return line.Split(" ")[2];
        }

        public string GetSortCommand(string line)
        {
            return line.Split("-sort=")[1].Split(" ")[0];
        }
        public string GetPriorityCommand(string line)
        {
            return line.Split("-priority=")[1].Split(" ")[0];
        }
        public string GetStatusCommand(string line)
        {
            return line.Split("-status=")[1].Split(" ")[0];
        }
    }
}
