using System;
using System.Collections.Generic;

namespace User.Domain.Models
{
    public partial class Cera
    {
        public Cera()
        {
            CeraOrders = new HashSet<CeraOrder>();
        }

        public int CeraId { get; set; }
        public string Number { get; set; } = null!;
        public decimal Amount { get; set; }
        public string UpdateBy { get; set; } = null!;
        public DateTime UpdateTime { get; set; }
        public DateTime UpdateUtcTime { get; set; }

        public virtual ICollection<CeraOrder> CeraOrders { get; set; }
    }
}
