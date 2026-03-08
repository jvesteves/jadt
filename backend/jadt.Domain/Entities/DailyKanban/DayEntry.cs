namespace jadt.Domain.Entities.DailyKanban
{
    public class DayEntry : BaseEntity
    {
        public Guid UserId { get; set; }
        public DateOnly Date { get; set; }
        public ICollection<DailyTask> DailyTasks { get; set; } = new List<DailyTask>();
    }
}
