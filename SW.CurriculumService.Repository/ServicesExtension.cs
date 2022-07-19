namespace SW.CurriculumService.Repository
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using SW.CurriculumService.Repository.Repositories;

    public static class ServicesExtension
    {
        public static void AddRepositoryServices(this IServiceCollection service, string connectionString)
        {
            service.AddDbContext<TaskDbContext>(option => option.UseSqlServer(connectionString));

            service.AddTransient<ITaskRepository, TaskRepository>();
        }
    }
}
