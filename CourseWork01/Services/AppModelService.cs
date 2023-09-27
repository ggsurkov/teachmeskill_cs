using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using CourseWork01.Interfaces;
using Newtonsoft.Json;
using TodoAppInterfaces.Task;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace CourseWork01.Services
{
    internal class AppModelService : IAppRecords
    {
        string _path = "TodoApp_file_system.json";
        public AppModelService()
        {
            TaskList = new List<TaskModel>();
        }

        public List<TaskModel> TaskList { get; set; }

        public List<TaskModel> GetTaskList()
        {
            return LoadJson();
        }
        public void AddTaskInList(TaskModel task)
        {
            List<TaskModel> taskList = LoadJson();
            taskList.Add(task);
            UpdateJsonFile(taskList);
        }
        public void RemoveTaskFromList(string name)
        {
            List <TaskModel> taskList  = LoadJson();
            TaskModel currentTask = taskList.FirstOrDefault((t) => t.Name == name);
            if (currentTask != null)
            {
                taskList.Remove(currentTask);
                UpdateJsonFile(taskList);
            }
            
        }
        public void UpdateTaskFromList(string name, string param, string paramType)
        {

            List<TaskModel> taskList = LoadJson();
            TaskModel currentTask = taskList.FirstOrDefault((tsk) => tsk.Name == name);
            if (currentTask != null && paramType != null) 
            { 
                switch (paramType)
                {
                    case "deadline":
                        currentTask.Deadline = param;
                        break;
                    case "status":
                        currentTask.Status = param;
                        break;
                    default: break;

                }
                
                UpdateJsonFile(taskList);
            }
        }

        private void UpdateJsonFile(List<TaskModel> taskList)
        {
            string json = JsonConvert.SerializeObject(taskList);
            File.WriteAllText(_path, json);
        }
        private List<TaskModel> LoadJson()
        {
            string json = System.IO.File.ReadAllText("TodoApp_file_system.json");
            List<TaskModel> result = JsonSerializer.Deserialize<List<TaskModel>>(json);
            return result;
        }
    }
}
