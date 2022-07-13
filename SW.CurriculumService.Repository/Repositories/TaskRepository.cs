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

        public IQueryable<TaskProgressDb> Get()
        {
            return this.db.Tasks;
        }

        public TaskProgressDb GetId(string taskId)
        {
            return this.db.Tasks.FirstOrDefault(
                t => t.TaskId == taskId);
        }

        public IQueryable<TaskProgressDb> GetForUser (string userId)
        {
            return this.db.Tasks.Where(
                t => t.UserId == userId);
        }
    }
}
