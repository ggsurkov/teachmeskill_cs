using CourseWork01.Model;

namespace TodoAppInterfaces.Task
{
    internal class TaskModel : ITask
    {
        public TaskModel()
        {

        }
        
        public string Name { get; set; }
        public string Deadline { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
    }
}
