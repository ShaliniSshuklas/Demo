namespace User.Domain.Models
{
    public partial class Area
    {
        public int AreaId { get; set; }
        public string AreaDesc { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime UpdateTime { get; set; }
        public DateTime UpdateUtcTime { get; set; }
    }
}
