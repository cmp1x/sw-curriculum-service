namespace SW.CurriculumService.Core.Models
{
    using System;

    public class TrainingDate
    {
        public DateTime Date { get; set; }

        public TimeSpan Duration { get; set; }

        public DateTime TimeToBegin { get; set; }

        public DateTime TimeToFinish { get; set; }
    }
}
