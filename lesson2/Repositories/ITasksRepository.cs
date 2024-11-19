using lesson2.Models;

namespace lesson2.Repositories
{
    public interface ITasksRepository
    {
        List<Tasks> GetTasks();



        void CreateTask(Tasks newTask);

        void UpdateTask(Tasks tasks);

        void DeleteTask(int id);

    }
}
