using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CourseWork01.Interfaces;
using CourseWork01.Model;
using TodoAppInterfaces.Task;

namespace CourseWork01.Services
{
    internal class TodoOptionsService
    {
        public readonly AppModelService _appModelService;

        public TodoOptionsService()
        {
            _appModelService = new AppModelService();
        }
        public void DisplayTasks(string line)
        {

            List<TaskModel> tasks = _appModelService.GetTaskList();

            for (int i = 0; i < tasks.Count; i++)
            {
                string displayLine = $"{tasks[i].Name} {tasks[i].Status} {tasks[i].Priority} {tasks[i].Deadline}";
                Console.WriteLine(displayLine);
            }
        }

        public void ChangeDeadlineByName()
        {
            Console.WriteLine("\r\n Write the name of task:");
            string name = Console.ReadLine();

            Console.WriteLine("\r\n Write the new deadline for task (example: 20/09/2024):");
            string deadline = Console.ReadLine();

            TaskModel updatedTask = new TaskModel();
            updatedTask.Name = name;
            updatedTask.Deadline = deadline;
            string paramType = "deadline";
            _appModelService.UpdateTaskFromList(name, deadline, paramType);
        }

        public void ChangeStatusByName()
        {
            Console.WriteLine("\r\n Write the name of task:");
            string name = Console.ReadLine();

            Console.WriteLine("\r\n Write the new status (Done, InProgress, Todo):");
            string status = Console.ReadLine();

            TaskModel updatedTask = new TaskModel();
            updatedTask.Name = name;
            updatedTask.Status = status;
            string paramType = "status";
            _appModelService.UpdateTaskFromList(name, status, paramType);
        }

        public TaskModel CreateNewTask()
        {
            Console.WriteLine("\r\n Write the name of task:");
            string name = Console.ReadLine();

            Console.WriteLine("\r\n Write the deadline of task (mask: 30/04/2024):");
            string deadline = Console.ReadLine();

            string statusInfo = "Done, InProgress, Todo";
            Console.WriteLine($"\r\n Write the status of task ({statusInfo}):");
            string status = Console.ReadLine();

            string priorityInfo = "High, Medium, Low";
            Console.WriteLine($"\r\n Write the priority of task ({priorityInfo}):");
            string priority = Console.ReadLine();

            TaskModel newTask = new TaskModel() { Name = name, Deadline = deadline, Priority = priority, Status = status };
            return newTask;
        }

        public void DeleteTaskByName()
        {
            Console.WriteLine("Write the Name of task for deleting: ");
            string taskName = Console.ReadLine();
            _appModelService.RemoveTaskFromList(taskName);
        }
    }
}
