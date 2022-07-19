namespace SW.CurriculumService.Repository.Models
{
    using SW.CurriculumService.Repository.Enums;
    using System.ComponentModel.DataAnnotations;


    public class StatusStateDb
    {
        [Key]
        public int StatusStateId { get; set; }

        public StatusState StatusState { get; set; }
    }
}
