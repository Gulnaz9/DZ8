using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class TaskManager
    {
        private List<Project> projects;
        private List<string> employees;

        public TaskManager()
        {
            projects = new List<Project>();
            employees = new List<string>() { "Person1", "Person2", "Person3", "Person4", "Person5", "Person6", "Person7", "Person8", "Person9", "Person10" };
        }
        public void CreateProject(string description, DateTime deadline, string initiator, string teamLead)
        {
            Project project = new Project()
            {
                Description = description,
                Deadline = deadline,
                Initiator = initiator,
                TeamLead = teamLead,
                Tasks = new List<Task>(),
                Status = ProjectStatus.Проект
            };

            projects.Add(project);
        }
        public void CreateTask(int proj, string taskDescription, DateTime taskDeadline, string taskInitiator)
        {
            Task task = new Task()
            {
                Description = taskDescription,
                Deadline = taskDeadline,
                Initiator = taskInitiator,
                Executor = "Person1",
                Status = TaskStatus.Назначена,
                Reports = new List<Report>()
            };

            projects[proj].Tasks.Add(task);
        }


        public void GiveTask(int proj, string executor)
        {
            if (projects[proj].Status == ProjectStatus.Проект)
            {
                Task task = new Task();
                task.Executor = executor;
                task.Status = TaskStatus.Назначена;
            }
            else
            {
                Console.WriteLine("Проект не создан");
            }
        }


        public void CreateReport(string text, DateTime executionDate, string executor)
        {
           Report report = new Report()
           {
             Text = text,
             ExecutionDate = executionDate,
             Executor = executor
             };
        }
        //сделала не полностью
    }
}
