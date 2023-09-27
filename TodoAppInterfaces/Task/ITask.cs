using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppInterfaces.Task
{
    public interface ITask
    {
        string Name { get; }
        string Deadline { get; }
        TaskStatus Status { get; }
        TaskPriority Priority { get; }

    }

    public enum TaskStatuses
    {
        Done, InProgress, Todo
    }
    public enum TaskPriority
    {
        High, Medium, Low
    }
}
