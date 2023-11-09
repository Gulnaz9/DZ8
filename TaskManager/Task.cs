using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static TaskManager.Project;

namespace TaskManager
{
    public enum TaskStatus
    {
        Назначена,
        В_работе,
        На_проверке,
        Выполнена
    }
    internal class Task
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Initiator { get; set; }
        public string Executor { get; set; }
        public TaskStatus Status { get; set; }
        public List<Report> Reports { get; set; }

        
    }
}
