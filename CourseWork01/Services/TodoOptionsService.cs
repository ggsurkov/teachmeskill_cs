using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork01.Interfaces;

namespace CourseWork01.Services
{
    internal class TodoOptionsService
    {
        public void DisplayTasks(string priority, string status, string sort)
        {

        }

        public void ChangeDeadlineByName(string name, string deadline)
        {

        }

        public void ChangeStatusByName(string name, string status)
        {

        }

        public void AddNewTask()
        {
            Console.WriteLine("\r\n Write the name of task:");
            string name = Console.ReadLine();

            string statusInfo = "Todo, InProgress, Done";
            Console.WriteLine($"\r\n Write the status of task ({statusInfo}):");
            string status = Console.ReadLine();

            Console.WriteLine("\r\n Write the deadline of task (mask: 30/04/2024):");
            string deadline = Console.ReadLine();
        }

        public void DeleteTaskByName(string Name)
        {

        }

        public void ShowHelp()
        {

        }
    }
}
