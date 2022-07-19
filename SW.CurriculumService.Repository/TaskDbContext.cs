namespace SW.CurriculumService.Repository
{
    using Microsoft.EntityFrameworkCore;
    using SW.CurriculumService.Repository.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TaskDbContext: DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> contextOptions)
            :base (contextOptions)
        {
        }

        public DbSet<TaskProgressDb> Tasks { get; set; }

        public DbSet<TrainigDateDb> TrainingDates { get; set; }

        public DbSet<PriorityColorDb> PriorityColors { get; set; }

        public DbSet<StatusStateDb> StatusStates { get; set; }
    }
}
