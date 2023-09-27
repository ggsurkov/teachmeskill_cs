using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppInterfaces.Task
{
    private string _name;
    private string _deadline;
    private TaskStatus _status;
    private TaskPriority _priority;
    internal class Task : ITask
    {
        public Task(string name, string deadline, TaskStatus status, TaskPriority prioirty)
        {
            _name = name;
            _deadline = deadline;
            _status = status;
            _priority = prioirty;
        }
    }
}
