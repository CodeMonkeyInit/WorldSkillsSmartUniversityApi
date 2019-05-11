using System;
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

        public IQueryable<Room> GetOwnedRooms(string userName) => 
            Rooms.Where(room => room.User.Username == userName);


        public async Task<Macro> GetMacroAsync(int id, string ownerName) =>
            await GetMacrosAsync(ownerName)
                .Include(macro => macro.Devices)
                .ThenInclude(device => device.Device)
                .FirstOrDefaultAsync(macro => macro.Id == id);

        public IQueryable<Macro> GetMacrosAsync(string ownerName) =>
            Macros.Where(macro => macro.UserId == ownerName);


        public Task<List<Device>> GetDevicesInRoomAsync(int roomId, string ownerName) =>
            GetDevices(ownerName)
                .Where(d => d.RoomId == roomId)
                .AsNoTracking()
                .ToListAsync();

        public Task<Device> GetDeviceAsync(int deviceId, string ownerName) =>
            GetDevices(ownerName).FirstOrDefaultAsync(device => device.Id == deviceId);

        public IIncludableQueryable<Device, Room> GetDevices(string ownerName) =>
            Devices
                .Where(device => device.UserId == ownerName)
                .Include(d => d.Room);


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var users = Enumerable.Range(1, 20)
                .Select(i => CreateUser("ws", i)).Union(
                    Enumerable.Range(1, 20)
                        .Select(i => CreateUser("demo", i + 20)))
                .ToList();


            modelBuilder.Entity<User>().HasData(users);

            modelBuilder.Entity<Room>().HasData(users.SelectMany(user => user.Rooms));
            modelBuilder.Entity<Device>().HasData(users.SelectMany(user => user.Devices));

            users.ForEach(user =>
            {
                user.Rooms.Clear();
                user.Devices.Clear();
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

        private static User CreateUser(string ws, int i)
        {
            string userId = ws + i;
            int roomId = -i;
            int deviceIdBase = i * 5;

            return new User
            {
                Username = userId,
                Password = string.Join(string.Empty, Guid.NewGuid()
                    .ToString()
                    .Take(6)),
                Rooms = new List<Room>
                {
                    new Room
                    {
                        Id = roomId,
                        Name = "Г-511",
                        Photo = "image.png",
                        UserId = userId
                    }
                },
                Devices = new List<Device>
                {
                    new Device
                    {
                        Id = -(deviceIdBase - 1),
                        Name = "Люстра",
                        Value = "off",
                        RoomId = roomId,
                        Type = DeviceType.LightBulb,
                        UserId = userId
                    },
                    new Device
                    {
                        Id = -(deviceIdBase - 2),
                        Name = "Окно",
                        Value = "closed",
                        RoomId = roomId,
                        Type = DeviceType.Window,
                        UserId = userId
                    },
                    new Device
                    {
                        Id = -(deviceIdBase - 3),
                        Name = "Кондиционер",
                        Value = "+20",
                        RoomId = roomId,
                        Type = DeviceType.AirConditioner,
                        UserId = userId
                    },
                    new Device
                    {
                        Id = -(deviceIdBase - 4),
                        Name = "Датчик температуры",
                        Value = "+20",
                        RoomId = roomId,
                        Type = DeviceType.TemperatureSensor,
                        UserId = userId
                    }
                }
            };
        }

        public SmartUniversityDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}