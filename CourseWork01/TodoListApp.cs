using CourseWork01.Interfaces;
using CourseWork01.Services;
using TodoAppInterfaces.Task;

namespace CourseWork01
{
    internal class TodoListApp
    {
        public readonly ILogger _logger;
        public readonly TodoOptionsService _todoOptionsService;
        public readonly AppModelService _appModelService;

        public TodoListApp()
        {
            _todoOptionsService = new TodoOptionsService();
            _appModelService = new AppModelService();
            
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
                    _todoOptionsService.DisplayTasks(line);
                    return true;
                case "2":
                    _todoOptionsService.ChangeDeadlineByName();
                    return true;
                case "3":
                    _todoOptionsService.ChangeStatusByName();
                    return true;
                case "4":
                    TaskModel newTask = _todoOptionsService.CreateNewTask();
                    _appModelService.AddTaskInList(newTask);
                    return true;
                case "5":
                    _todoOptionsService.DeleteTaskByName();
                    return true;
                case "6":
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
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");
        }
    }
}
