using jadt.Domain.Entities.DailyKanban.Enum;

namespace jadt.Domain.Entities.DailyKanban
{
    public class DailyTask : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }

        public TimeOnly HourStarted { get; set; }
        public TimeOnly HourCompleted { get; set; }
        public required Period Period { get; set; }
        public DayEntry? DayEntry { get; set; }
        public required Guid DayEntryId { get; set; }
        public string? Localization { get; set; }
        public Guid? ProjectTaskId { get; set;  }

    }
}
