using jadt.Domain.Entities.DailyKanban.Enum;

namespace jadt.Domain.Entities.DailyKanban
{
    public class RecurrenceRule : BaseEntity
    {
        public DailyTask? DailyTask { get; set; }
        public Guid DailyTaskId { get; set; }
        public DaysOfWeek RecurrenceDays { get; set; }
        public DateOnly? RecurrenceDateEnd { get; set; }
    }
}
