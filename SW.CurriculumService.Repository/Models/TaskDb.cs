namespace SW.CurriculumService.Repository.Models
{
    using SW.CurriculumService.Repository.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;


    public class TaskDb
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
    }
}
