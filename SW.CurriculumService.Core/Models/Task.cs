namespace SW.CurriculumService.Core.Models
{
    using SW.CurriculumService.Core.Enums;

    public class Task
    {
        public int Id { get; set; }

        public string TaskId { get; set; }

        public StatusState Status { get; set; }

        public bool IsCompleted { get; set; }

        public PriorityColor Priority { get; set; }

        public decimal HoursSpent { get; set; }

        public TrainingDate TrainingDates { get; set; }
    }
}
