namespace rpgGame.Models
{
    public class GuideViewModel
    {
        public List<ItemData> Items { get; set; } = new();
        public List<MonsterData> Monsters { get; set; } = new();
        public List<EventsData> Events { get; set; } = new();
        public List<StatusData> Statuses { get; set; } = new();
        public List<JobData> Jobs { get; set; } = new();
        public List<NatureData> Natures { get; set; } = new();
    }
}