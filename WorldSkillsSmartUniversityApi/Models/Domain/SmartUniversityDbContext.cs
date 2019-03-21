using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace WorldSkillsSmartUniversityApi.Models.Domain
{
    public class SmartUniversityDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<Macro> Macros { get; set; }

        public async Task<Macro> GetMacroAsync(int id) =>
            await Macros
                .Include(macro => macro.Devices)
                    .ThenInclude(device => device.Device)
                .FirstOrDefaultAsync(macro => macro.Id == id);


        public Task<List<Device>> GetDevicesInRoomAsync(int roomId) =>
            GetDevices()
                .Where(d => d.RoomId == roomId)
                .AsNoTracking()
                .ToListAsync();

        public Task<Device> GetDeviceAsync(int deviceId) =>
            GetDevices().FirstOrDefaultAsync(device => device.Id == deviceId);

        private IIncludableQueryable<Device, Room> GetDevices() =>
            Devices.Include(d => d.Room);


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            const int roomId = -1;
            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = roomId,
                Name = "A914", Photo = "sharaga.png"
            });

            modelBuilder.Entity<Device>().HasData(new[]
            {
                new Device
                {
                    Id = -1,
                    Name = "Люстра",
                    Value = "off",
                    RoomId = roomId,
                    Type = DeviceType.LightBulb
                },
                new Device
                {
                    Id = -2,
                    Name = "Окно",
                    Value = "closed",
                    RoomId = roomId,
                    Type = DeviceType.Window
                },
                new Device
                {
                    Id = -3,
                    Name = "Кондиционер",
                    Value = "+20",
                    RoomId = roomId,
                    Type = DeviceType.AirConditioner
                },
                new Device
                {
                    Id = -4,
                    Name = "Датчик температуры",
                    Value = "+20",
                    RoomId = roomId,
                    Type = DeviceType.TemperatureSensor
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