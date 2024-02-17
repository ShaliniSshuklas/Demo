using System;
using System.Collections.Generic;

namespace User.Domain.Models
{
    public partial class Calendar
    {
        public DateTime CalendarDate { get; set; }
        public string? CalendarDateString { get; set; }
        public byte? CalendarMonth { get; set; }
        public byte? CalendarDay { get; set; }
        public short? CalendarYear { get; set; }
        public byte? CalendarQuarter { get; set; }
        public string? DayName { get; set; }
        public byte? DayOfWeek { get; set; }
        public decimal? BusinessHours { get; set; }
        public byte? DayOfWeekInMonth { get; set; }
        public byte? DayOfWeekInYear { get; set; }
        public byte? DayOfWeekInQuarter { get; set; }
        public byte? DayOfQuarter { get; set; }
        public short? DayOfYear { get; set; }
        public byte? WeekOfMonth { get; set; }
        public byte? WeekOfQuarter { get; set; }
        public byte? WeekOfYear { get; set; }
        public string? MonthName { get; set; }
        public DateTime? FirstDateOfWeek { get; set; }
        public DateTime? LastDateOfWeek { get; set; }
        public DateTime? FirstDateOfMonth { get; set; }
        public DateTime? LastDateOfMonth { get; set; }
        public DateTime? FirstDateOfQuarter { get; set; }
        public DateTime? LastDateOfQuarter { get; set; }
        public DateTime? FirstDateOfYear { get; set; }
        public DateTime? LastDateOfYear { get; set; }
        public bool? IsHoliday { get; set; }
        public bool? IsHolidaySeason { get; set; }
        public string? HolidayName { get; set; }
        public string? HolidaySeasonName { get; set; }
        public bool? IsWeekday { get; set; }
        public bool? IsBusinessDay { get; set; }
        public bool? IsLeapYear { get; set; }
        public byte? DaysInMonth { get; set; }
        public string UpdatedBy { get; set; } = null!;
        public DateTime UpdateTime { get; set; }
        public DateTime UpdateUtcTime { get; set; }
    }
}
