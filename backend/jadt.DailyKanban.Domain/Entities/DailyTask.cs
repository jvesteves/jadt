using jadt.DailyKanban.Domain.Entities.Enum;
using jadt.Shared.Domain.Entities;

namespace jadt.DailyKanban.Domain.Entities
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
