using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppInterfaces
{
    public interface TaskInterface
    {
        string Name { get; }
        DateTime Deadline { get; }
        TaskStatus Status { get; }
        TaskStatus Priority { get; }

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
