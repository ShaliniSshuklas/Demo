using System;
using System.Collections.Generic;

namespace User.Domain.Models
{
    public partial class CeraOrder
    {
        public int CeraOrderId { get; set; }
        public string Number { get; set; } = null!;
        public int CeraId { get; set; }
        public decimal Amount { get; set; }
        public string UpdateBy { get; set; } = null!;
        public DateTime UpdateTime { get; set; }
        public DateTime UpdateUtcTime { get; set; }

        public virtual Cera Cera { get; set; } = null!;
    }
}
