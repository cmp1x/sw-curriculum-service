namespace SW.CurriculumService.Repository
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class ServicesExtension
    {
        public static void AddRepositoryServices(this IServiceCollection service, string connectionString)
        {
            service.AddDbContext<TaskDbContext>(option => option.UseSqlServer(connectionString));
        }
    }
}
