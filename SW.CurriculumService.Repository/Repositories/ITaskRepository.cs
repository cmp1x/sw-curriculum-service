namespace SW.CurriculumService.Repository.Repositories
{
    using SW.CurriculumService.Repository.Models;
    using System.Linq;

    public interface ITaskRepository
    {
        IQueryable<TaskProgressDb> Get();

        TaskProgressDb GetId(string taskId);

        IQueryable<TaskProgressDb> GetForUser(string userId);
    }
}