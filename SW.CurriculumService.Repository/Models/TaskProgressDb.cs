namespace SW.CurriculumService.Repository.Models
{
    using SW.CurriculumService.Repository.Enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TaskProgressDb
    {
        [Key]
        public int Id { get; set; }

        public string TaskId { get; set; }

        [ForeignKey("StatusColorDb")]
        public StatusState Status { get; set; }

        public bool IsCompleted { get; set; }

        [ForeignKey("PriorityColorDb")]
        public PriorityColor Priority { get; set; }

        public decimal HoursSpent { get; set; }

        public virtual ICollection<TrainigDateDb> TrainigDates { get; set; }

        public string UserId { get; set; }
    }
}
