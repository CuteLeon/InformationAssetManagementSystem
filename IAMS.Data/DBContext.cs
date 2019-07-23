using IAMS.Model;
using Microsoft.EntityFrameworkCore;

namespace IAMS.Data
{
    /// <summary>
    /// 数据库交互类
    /// </summary>
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<AuxiliaryComputer> AuxiliaryComputers { get; set; }

        public DbSet<DesktopComputer> DesktopComputers { get; set; }

        public DbSet<LaptopComputer> LaptopComputers { get; set; }

        public DbSet<OtherEquipment> OtherEquipments { get; set; }

        public DbSet<RoomEquipment> RoomEquipments { get; set; }
    }
}
