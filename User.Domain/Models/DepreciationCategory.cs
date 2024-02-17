using System;
using System.Collections.Generic;

namespace User.Domain.Models
{
    public partial class DepreciationCategory
    {
        public int DepreciationId { get; set; }
        public string DepreciationCategoryDesc { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime UpdateTime { get; set; }
        public DateTime UpdateUtcTime { get; set; }
    }
}
