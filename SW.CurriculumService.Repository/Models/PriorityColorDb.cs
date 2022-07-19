namespace SW.CurriculumService.Repository.Models
{
    using SW.CurriculumService.Repository.Enums;
    using System.ComponentModel.DataAnnotations;

    public class PriorityColorDb
    {
        [Key]
        public int PriorityColorId { get; set; }

        public PriorityColor PriorityColor { get; set; }
    }
}
