using lesson2.Models;
using System.Text.Json;
using System.Threading.Tasks;

namespace lesson2.Repositories
{
    public class TasksRepository:ITasksRepository
    {
        private readonly TasksDbContext _context;
        public TasksRepository(TasksDbContext context)
        {
            _context = context;
        }
        
        public List<Tasks> GetTasks()
        {
                return _context.Tasks.ToList();
        }



        public void CreateTask(Tasks Task)
        {
            _context.Tasks.Add(Task);
            _context.SaveChanges();

        }
        public void UpdateTask(Tasks Task)
        {
            _context.Tasks.Update(Task);
            _context.SaveChanges();

        }
    

    public void DeleteTask(int id)
    {
            Tasks? tasks = _context.Tasks.Find(id);
            if(tasks!=null)
            {
                _context.Tasks.Remove(tasks);
                _context.SaveChanges();
            }
    }
}
}
