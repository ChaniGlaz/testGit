using lesson2.Models;

namespace lesson2.Services
{
    public interface ITasksServices
    {
        List<Tasks> GetTasks();

        //Tasks GetTaskById(int id);

        Tasks CreateTask(Tasks newTask);
        void UpdateTask(Tasks oneTask);

        void DeleteTask(int id);
    }
}
