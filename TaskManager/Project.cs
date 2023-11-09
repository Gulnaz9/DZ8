using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaskManager.Task;

namespace TaskManager
{
    public enum ProjectStatus
    {
        Проект,
        Исполнение,
        Закрыт
    }
    internal class Project
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Initiator { get; set; }
        public string TeamLead { get; set; }
        public List<Task> Tasks { get; set; }
        public ProjectStatus Status { get; set; }

        
    }
}
