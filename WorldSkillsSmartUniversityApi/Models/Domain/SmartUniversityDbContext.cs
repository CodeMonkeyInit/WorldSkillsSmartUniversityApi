using Microsoft.EntityFrameworkCore;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class SmartUniversityDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<Macro> Macros { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            const int roomId = -1;
            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = roomId,
                Name = "A914", Photo = "sharaga.png"
            });


            modelBuilder.Entity<DeviceType>().HasData(new DeviceType
                {
                    Id = -1,
                    Name = "Переключатели"
                }, new DeviceType
                {
                    Id = -2,
                    Name = "Окна"
                },
                new DeviceType
                {
                    Id = -3,
                    Name = "Температурные"
                });

            modelBuilder.Entity<Device>().HasData(new[]
            {
                new Device
                {
                    Id = -1,
                    Name = "Люстра",
                    Value = "off",
                    RoomId = roomId,
                    TypeId = -1
                },
                new Device
                {
                    Id = -2,
                    Name = "Окно",
                    Value = "closed",
                    RoomId = roomId,
                    TypeId = -2
                },
                new Device
                {
                    Id = -3,
                    Name = "Кондиционер",
                    Value = "+20",
                    RoomId = roomId,
                    TypeId = -3
                }
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = -1,
                Username = "Vitya",
                Password = "pitux"
            });
            
            modelBuilder.Entity<MacroDevice>()
                .HasKey(macroDevice => new {macroDevice.MacroId, macroDevice.DeviceId});

            modelBuilder.Entity<MacroDevice>()
                .HasOne(macroDevice => macroDevice.Macro)
                .WithMany(macro => macro.Devices)
                .HasForeignKey(macroDevice => macroDevice.MacroId);

            modelBuilder.Entity<MacroDevice>()
                .HasOne(macroDevice => macroDevice.Device)
                .WithMany(device => device.Macros)
                .HasForeignKey(macroDevice => macroDevice.DeviceId);
            
            base.OnModelCreating(modelBuilder);
        }

        public SmartUniversityDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}