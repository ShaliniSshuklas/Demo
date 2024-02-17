using Microsoft.EntityFrameworkCore;
using User.Domain.Models;

namespace User.Domain.Context
{
    public partial class CAPEXContext : DbContext
    {
        public CAPEXContext()
        {
        }

        public CAPEXContext(DbContextOptions<CAPEXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<Calendar> Calendars { get; set; } = null!;
        public virtual DbSet<Cera> Ceras { get; set; } = null!;
        public virtual DbSet<CeraOrder> CeraOrders { get; set; } = null!;
        public virtual DbSet<CostCenter> CostCenters { get; set; } = null!;
        public virtual DbSet<Crcschedule> Crcschedules { get; set; } = null!;
        public virtual DbSet<DepreciationCategory> DepreciationCategories { get; set; } = null!;
        public virtual DbSet<Resident> Residents { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SHALINI\\SQLEXPRESS01;Initial Catalog=CAPEX;Persist Security Info=True;\nUser ID=Shalu;Password=1234;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;\nTrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("Area");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaDesc).HasMaxLength(150);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUtcTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_utc_time")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .HasColumnName("updated_by")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.CalendarDate)
                    .HasName("PK_Dim_Date");

                entity.ToTable("Calendar");

                entity.Property(e => e.CalendarDate)
                    .HasColumnType("date")
                    .HasColumnName("Calendar_Date");

                entity.Property(e => e.BusinessHours).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.CalendarDateString)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Calendar_Date_String");

                entity.Property(e => e.CalendarDay).HasColumnName("Calendar_Day");

                entity.Property(e => e.CalendarMonth).HasColumnName("Calendar_Month");

                entity.Property(e => e.CalendarQuarter).HasColumnName("Calendar_Quarter");

                entity.Property(e => e.CalendarYear).HasColumnName("Calendar_Year");

                entity.Property(e => e.DayName)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Day_Name");

                entity.Property(e => e.DayOfQuarter).HasColumnName("Day_of_Quarter");

                entity.Property(e => e.DayOfWeek).HasColumnName("Day_of_Week");

                entity.Property(e => e.DayOfWeekInMonth).HasColumnName("Day_of_Week_in_Month");

                entity.Property(e => e.DayOfWeekInQuarter).HasColumnName("Day_of_Week_in_Quarter");

                entity.Property(e => e.DayOfWeekInYear).HasColumnName("Day_of_Week_in_Year");

                entity.Property(e => e.DayOfYear).HasColumnName("Day_of_Year");

                entity.Property(e => e.DaysInMonth).HasColumnName("Days_in_Month");

                entity.Property(e => e.FirstDateOfMonth)
                    .HasColumnType("date")
                    .HasColumnName("First_Date_of_Month");

                entity.Property(e => e.FirstDateOfQuarter)
                    .HasColumnType("date")
                    .HasColumnName("First_Date_of_Quarter");

                entity.Property(e => e.FirstDateOfWeek)
                    .HasColumnType("date")
                    .HasColumnName("First_Date_of_Week");

                entity.Property(e => e.FirstDateOfYear)
                    .HasColumnType("date")
                    .HasColumnName("First_Date_of_Year");

                entity.Property(e => e.HolidayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Holiday_Name");

                entity.Property(e => e.HolidaySeasonName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Holiday_Season_Name");

                entity.Property(e => e.IsBusinessDay).HasColumnName("Is_Business_Day");

                entity.Property(e => e.IsHoliday).HasColumnName("Is_Holiday");

                entity.Property(e => e.IsHolidaySeason).HasColumnName("Is_Holiday_Season");

                entity.Property(e => e.IsLeapYear).HasColumnName("Is_Leap_Year");

                entity.Property(e => e.IsWeekday).HasColumnName("Is_Weekday");

                entity.Property(e => e.LastDateOfMonth)
                    .HasColumnType("date")
                    .HasColumnName("Last_Date_of_Month");

                entity.Property(e => e.LastDateOfQuarter)
                    .HasColumnType("date")
                    .HasColumnName("Last_Date_of_Quarter");

                entity.Property(e => e.LastDateOfWeek)
                    .HasColumnType("date")
                    .HasColumnName("Last_Date_of_Week");

                entity.Property(e => e.LastDateOfYear)
                    .HasColumnType("date")
                    .HasColumnName("Last_Date_of_Year");

                entity.Property(e => e.MonthName)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("Month_Name");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUtcTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_utc_time")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .HasColumnName("updated_by")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.WeekOfMonth).HasColumnName("Week_of_Month");

                entity.Property(e => e.WeekOfQuarter).HasColumnName("Week_of_Quarter");

                entity.Property(e => e.WeekOfYear).HasColumnName("Week_of_Year");
            });

            modelBuilder.Entity<Cera>(entity =>
            {
                entity.ToTable("Cera");

                entity.HasIndex(e => e.Number, "UQ__Cera__78A1A19D281C36EE")
                    .IsUnique();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Number).HasMaxLength(200);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(20)
                    .HasColumnName("update_by")
                    .HasDefaultValueSql("(suser_name())");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUtcTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_utc_time")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<CeraOrder>(entity =>
            {
                entity.ToTable("CeraOrder");

                entity.HasIndex(e => e.Number, "UQ__CeraOrde__78A1A19D5237DC17")
                    .IsUnique();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Number).HasMaxLength(200);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(20)
                    .HasColumnName("update_by")
                    .HasDefaultValueSql("(suser_name())");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUtcTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_utc_time")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Cera)
                    .WithMany(p => p.CeraOrders)
                    .HasForeignKey(d => d.CeraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CeraOrder_Cera");
            });

            modelBuilder.Entity<CostCenter>(entity =>
            {
                entity.ToTable("CostCenter");

                entity.Property(e => e.CostCenterId).HasColumnName("CostCenterID");

                entity.Property(e => e.CostCenterDescription).HasMaxLength(200);

                entity.Property(e => e.FunctionalArea).HasMaxLength(150);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUtcTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_utc_time")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .HasColumnName("updated_by")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Crcschedule>(entity =>
            {
                entity.ToTable("CRCSchedule");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crcdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CRCDate");

                entity.Property(e => e.NonMfgsubmission)
                    .HasColumnType("datetime")
                    .HasColumnName("NonMFGSubmission");

                entity.Property(e => e.PreReviewDeadline).HasColumnType("datetime");

                entity.Property(e => e.SubmissionDeadline).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUtcTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_utc_time")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .HasColumnName("updated_by")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<DepreciationCategory>(entity =>
            {
                entity.HasKey(e => e.DepreciationId);

                entity.ToTable("DepreciationCategory");

                entity.Property(e => e.DepreciationId).HasColumnName("DepreciationID");

                entity.Property(e => e.DepreciationCategoryDesc).HasMaxLength(150);

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateUtcTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_utc_time")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .HasColumnName("updated_by")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Resident>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
