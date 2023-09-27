using CourseWork01.Model;
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
        string Status { get; }
        string Priority { get; }

    }
}
