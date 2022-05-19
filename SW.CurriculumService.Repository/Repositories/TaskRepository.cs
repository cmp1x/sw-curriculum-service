namespace SW.CurriculumService.Repository.Repositories
{
    using SW.CurriculumService.Repository.Models;
    using System.Linq;

    public class TaskRepository : ITaskRepository
    {
        private TaskDbContext db;

        public TaskRepository(TaskDbContext db)
        {
            this.db = db;
        }

        public IQueryable<TaskDb> Get()
        {
            return this.db.Tasks;
        }

        public TaskDb GetId(string id)
        {
            return this.db.Tasks.FirstOrDefault(
                t => t.TaskId == id);
        }
    }
}
