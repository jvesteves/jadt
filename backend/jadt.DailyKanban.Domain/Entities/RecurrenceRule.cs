using jadt.DailyKanban.Domain.Entities.Enum;
using jadt.Shared.Domain.Entities;

namespace jadt.DailyKanban.Domain.Entities
{
    public class RecurrenceRule : BaseEntity
    {
        public DailyTask? DailyTask { get; set; }
        public Guid DailyTaskId { get; set; }
        public DaysOfWeek RecurrenceDays { get; set; }
        public DateOnly? RecurrenceDateEnd { get; set; }
    }
}
