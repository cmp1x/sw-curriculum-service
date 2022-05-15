namespace SW.CurriculumService.Repository
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using SW.CurriculumService.Repository.Enums;
    using SW.CurriculumService.Repository.Models;
    using System;

    public static class DbInitialiazer
    {
        public static void DbInitialize(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                using (var db = scope.ServiceProvider.GetService<TaskDbContext>())
                {
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    // PriorityColor
                    db.PriorityColors.Add(new PriorityColorDb() { PriorityColor = PriorityColor.RED });
                    db.SaveChanges();

                    // StatusState
                    db.StatusStates.Add(new StatusStateDb() { StatusState = StatusState.INPROGRESS });
                    db.SaveChanges();

                    // TrainigDate
                    db.TrainingDates.Add(new TrainigDateDb() { Date=new DateTime(2015, 03, 19, 2, 13, 55), Duration=new TimeSpan (0,30,12), TaskId = 1 });
                    db.TrainingDates.Add(new TrainigDateDb() { Date=new DateTime(2015, 03, 20, 12, 22, 58), Duration=new TimeSpan (0,12,54), TaskId = 1 });
                    db.SaveChanges();

                    // Task
                    db.Tasks.Add(new TaskDb()
                    {
                        TaskId = "BcC3wjiURyg",
                        Status = StatusState.INPROGRESS,
                        IsCompleted = false,
                        Priority = PriorityColor.RED,
                        HoursSpent = 123,
                    });
                    db.SaveChanges();
                }
            }
        }
    }
}
