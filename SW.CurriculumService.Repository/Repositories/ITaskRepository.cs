namespace SW.CurriculumService.Repository.Repositories
{
    using SW.CurriculumService.Repository.Models;
    using System.Linq;

    public interface ITaskRepository
    {
        IQueryable<TaskDb> Get();
        TaskDb GetId(string id);
    }
}