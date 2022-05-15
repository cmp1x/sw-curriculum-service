namespace SW.CurriculumService.Repository.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TrainigDateDb
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public TimeSpan Duration { get; set; }

        [ForeignKey("TaskDb")]
        public int TaskId { get; set; }
    }
}
