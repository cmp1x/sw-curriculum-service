namespace SW.CurriculumService.Web.Models
{
    using SW.CurriculumService.Web.Enums;

    public class Task
    {
        public int Id { get; set; }

        public string TaskId { get; set; }

        public StatusState Status { get; set; }

        public bool IsCompleted { get; set; }

        public PriorityColor Priority { get; set; }

        public decimal HoursSpent { get; set; }

        public TrainingDates TrainingDates { get; set; }
    }
}
