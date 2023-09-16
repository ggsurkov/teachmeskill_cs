using CourseWork01.Interfaces;
using CourseWork01.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork01
{
    internal class TodoListApp
    {
        public readonly ILogger _logger;
        public readonly TodoOptionsService _todoOptionsService;
        public readonly TodoLineParserService _todoLineParser;

        public TodoListApp()
        {
            _todoOptionsService = new TodoOptionsService();
            _todoLineParser = new TodoLineParserService();
            Run();
        }

        private void Run()
        {
            Console.WriteLine("Todo list loaded, please choose the option: \r\n");
          
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private bool MainMenu()
        {
            ShowMenuOptions();
            string line = Console.ReadLine();

            string firstChar = line.Substring(0, 1);

            switch (firstChar)
            {
                case "1":
                    string sort = _todoLineParser.GetSortCommand(line);
                    string priority = _todoLineParser.GetPriorityCommand(line);
                    string status = _todoLineParser.GetStatusCommand(line);

                    _todoOptionsService.DisplayTasks(priority, status, sort);
                    return true;
                case "2":
                    string name = _todoLineParser.GetSecondCommand(line);
                    string deadline = _todoLineParser.GetThirdCommand(line);

                    _todoOptionsService.ChangeDeadlineByName(name, deadline);
                    return true;
                case "3":
                    string taskName = _todoLineParser.GetSecondCommand(line);
                    string taskStatus = _todoLineParser.GetThirdCommand(line);

                    _todoOptionsService.ChangeStatusByName(taskName, taskStatus);
                    return true;
                case "4":
                    _todoOptionsService.AddNewTask();
                    return true;
                case "5":
                    string taskNameForDeleting = _todoLineParser.GetSecondCommand(line);

                    _todoOptionsService.DeleteTaskByName(taskNameForDeleting);
                    return true;
                case "6":
                    _todoOptionsService.ShowHelp();
                    return true;
                case "7":
                    return false;
                default:
                    return true;
            }
        }

        private void ShowMenuOptions()
        {
            Console.WriteLine("\r\n Choose an option:");
            Console.WriteLine("1) Display tasks");
            Console.WriteLine("2) Change tasks deadline by Name");
            Console.WriteLine("3) Change tasks status by Name");
            Console.WriteLine("4) To add new task");
            Console.WriteLine("5) To remove task by Name");
            Console.WriteLine("6) Help");
            Console.WriteLine("7) Exit");
            Console.Write("\r\nSelect an option: ");
        }
    }
}
