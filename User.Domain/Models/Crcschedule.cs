using System;
using System.Collections.Generic;

namespace User.Domain.Models
{
    public partial class Crcschedule
    {
        public int Id { get; set; }
        public short ScheduleYear { get; set; }
        public DateTime SubmissionDeadline { get; set; }
        public DateTime PreReviewDeadline { get; set; }
        public DateTime NonMfgsubmission { get; set; }
        public DateTime Crcdate { get; set; }
        public string UpdatedBy { get; set; } = null!;
        public DateTime UpdateTime { get; set; }
        public DateTime UpdateUtcTime { get; set; }
    }
}
