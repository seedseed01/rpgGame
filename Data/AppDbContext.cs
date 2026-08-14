using Microsoft.EntityFrameworkCore;
using rpgGame.Models;

namespace rpgGame.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // 這代表資料庫裡會有一張名為 ForumMessages 的資料表
        public DbSet<ForumMessage> ForumMessages { get; set; }
        public DbSet<ItemData> ItemDatas { get; set; }
        public DbSet<NatureData> NatureDatas { get; set; }
        public DbSet<MonsterData> MonsterDatas { get; set; }
        public DbSet<StatusData> StatusDatas { get; set; }
        public DbSet<EventsData> EventsDatas { get; set; }
        public DbSet<JobData> JobDatas { get; set; }
    }
}