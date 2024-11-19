
using lesson2.Models;
using lesson2.Repositories;
using System.Text.Json;

namespace lesson2.Services
{
    public class TasksServices:ITasksServices
    {
        private readonly ITasksRepository _TasksRepository;


        public TasksServices(ITasksRepository TasksRepository)
        {
            _TasksRepository = TasksRepository;
        }


        public List<Tasks> GetTasks()
        {
            var allTasks = _TasksRepository.GetTasks();
            return allTasks;
        }


        public Tasks CreateTask(Tasks TTask)
        {
            //var allTask = _TasksRepository.GetTasks();
            //TTask.id = allTask.Count + 1;
            //allTask.Add(TTask);
            _TasksRepository.CreateTask(TTask);
            return TTask;
        }

        //Tasks ITasksServices.GetTaskById(int id)
        //{

        //    var allTasks = _TasksRepository.GetTasks();

        //    var a = allTasks.FirstOrDefault(x => x.id == id);

        //    return a;

        //}

        public void UpdateTask(Tasks oneTask)
        {
            //var allTasks = _TasksRepository.GetTasks();
            //Tasks a = allTasks.FirstOrDefault(x => x.id == id);
            //if (a == null)
            //{
            //    return null; // Return an empty list if the file doesn't exist
            //}
            //a.status = "done";
            _TasksRepository.UpdateTask(oneTask);
            //return a;
        }
        public void DeleteTask(int id)
        {
            //var allTasks = _TasksRepository.GetTasks();
            //Tasks a = allTasks.FirstOrDefault(x => x.id == id);
            //if (a == null)
            //{
            //    return null; // Return an empty list if the file doesn't exist
            //}
            _TasksRepository.DeleteTask(id);
           
        }

    }
}
