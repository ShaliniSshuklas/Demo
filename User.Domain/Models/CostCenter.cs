using System;
using System.Collections.Generic;

namespace User.Domain.Models
{
    public partial class CostCenter
    {
        public int CostCenterId { get; set; }
        public string CostCenterDescription { get; set; } = null!;
        public string FunctionalArea { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime UpdateTime { get; set; }
        public DateTime UpdateUtcTime { get; set; }
    }
}
