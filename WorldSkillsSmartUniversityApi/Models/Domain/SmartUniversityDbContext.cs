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
            modelBuilder.Entity<Device>()
                .HasData(users.SelectMany(user => user.Rooms).SelectMany(rooms => rooms.Devices));

            users.ForEach(user =>
            {
                user.Rooms.ForEach(room => room.Devices.Clear());
                user.Rooms.Clear();
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
            int roomIdBase = -(i * 10);
            int deviceIdBase = -(i * 10);

            return new User
            {
                Username = userId,
                Password = string.Join(string.Empty, Guid.NewGuid()
                    .ToString()
                    .Take(6)),
                Rooms = Enumerable
                    .Range(roomIdBase, 6)
                    .Select((roomId, index) => GetRoom(roomId, deviceIdBase * roomId, userId, index))
                    .ToList()
            };
        }

        public static Room GetRoom(int roomId, int deviceIdBase, string userId, int index)
        {
            bool DividesBy(int value, int by) => value % by == 0;
            bool IsEven(int value) => DividesBy(value, 2);
            bool IsOdd(int value) => !IsEven(value);

            bool DeviceIncluded(Device device) =>
                (IsEven(roomId) && IsEven((int) device.Type))
                || (IsOdd(roomId) && IsOdd((int) device.Type));

            var devices = new List<Device>
            {
                new Device
                {
                    Id = deviceIdBase++,
                    Name = "Люстра",
                    Value = "off",
                    RoomId = roomId,
                    Type = DeviceType.LightBulb,
                    UserId = userId
                },
                new Device
                {
                    Id = deviceIdBase++,
                    Name = "Окно",
                    Value = "closed",
                    RoomId = roomId,
                    Type = DeviceType.Window,
                    UserId = userId
                },
                new Device
                {
                    Id = deviceIdBase++,
                    Name = "Кондиционер",
                    Value = "+20",
                    RoomId = roomId,
                    Type = DeviceType.AirConditioner,
                    UserId = userId
                },
                new Device
                {
                    Id = deviceIdBase++,
                    Name = "Датчик температуры",
                    Value = "+20",
                    RoomId = roomId,
                    Type = DeviceType.TemperatureSensor,
                    UserId = userId
                },
                new Device
                {
                    Id = deviceIdBase++,
                    Name = "Увлажнитель",
                    Value = "4",
                    RoomId = roomId,
                    Type = DeviceType.Humidifier,
                    UserId = userId
                },
                new Device
                {
                    Id = deviceIdBase++,
                    Name = "Дверь",
                    Value = "closed",
                    RoomId = roomId,
                    Type = DeviceType.Door,
                    UserId = userId
                },
            };
            return new Room
            {
                Id = roomId,
                Name = "Г" + roomId,
                Photo = $"images/room{index}.png",
                UserId = userId,
                Devices = devices
                    .Where(DeviceIncluded)
                    .OrderBy(key => Guid.NewGuid())
                    .ToList()
            };
        }


        public SmartUniversityDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}