using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppInterfaces.Task;

namespace CourseWork01.Interfaces
{
    internal interface IAppRecords
    {
        List<TaskModel> TaskList { get; }
    }
}
