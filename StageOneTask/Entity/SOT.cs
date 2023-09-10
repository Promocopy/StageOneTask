namespace StageOneTask.Entity
{
    public class SOT
    {
        public int Id { get; set; } 
        public String? SlackName { get; set; }
        public DateTime creationDate { get; set; }
        public DayOfWeek Day { get; set; } = DateTime.Today.DayOfWeek;
        public string? Track { get; set; }


    }
}
