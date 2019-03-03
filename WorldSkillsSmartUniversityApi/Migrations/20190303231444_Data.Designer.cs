﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldSkillsSmartUniversityApi.Models.Domain;

namespace WorldSkillsSmartUniversityApi.Migrations
{
    [DbContext(typeof(SmartUniversityDbContext))]
    [Migration("20190303231444_Data")]
    partial class Data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("WorldSkillsSmartUniversityApi.Models.Domain.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("RoomId");

                    b.Property<int>("TypeId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("TypeId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "Люстра",
                            RoomId = -1,
                            TypeId = -1,
                            Value = "off"
                        },
                        new
                        {
                            Id = -2,
                            Name = "Окно",
                            RoomId = -1,
                            TypeId = -2,
                            Value = "closed"
                        },
                        new
                        {
                            Id = -3,
                            Name = "Кондиционер",
                            RoomId = -1,
                            TypeId = -3,
                            Value = "+20"
                        });
                });

            modelBuilder.Entity("WorldSkillsSmartUniversityApi.Models.Domain.DeviceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DeviceType");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "Переключатели"
                        },
                        new
                        {
                            Id = -2,
                            Name = "Окна"
                        },
                        new
                        {
                            Id = -3,
                            Name = "Температурные"
                        });
                });

            modelBuilder.Entity("WorldSkillsSmartUniversityApi.Models.Domain.Macro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Macros");
                });

            modelBuilder.Entity("WorldSkillsSmartUniversityApi.Models.Domain.MacroDevice", b =>
                {
                    b.Property<int>("MacroId");

                    b.Property<int>("DeviceId");

                    b.Property<string>("Value");

                    b.HasKey("MacroId", "DeviceId");

                    b.HasIndex("DeviceId");

                    b.ToTable("MacroDevice");
                });

            modelBuilder.Entity("WorldSkillsSmartUniversityApi.Models.Domain.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Photo");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "A914",
                            Photo = "sharaga.png"
                        });
                });

            modelBuilder.Entity("WorldSkillsSmartUniversityApi.Models.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Password = "pitux",
                            Username = "Vitya"
                        });
                });

            modelBuilder.Entity("WorldSkillsSmartUniversityApi.Models.Domain.Device", b =>
                {
                    b.HasOne("WorldSkillsSmartUniversityApi.Models.Domain.Room", "Room")
                        .WithMany("Devices")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorldSkillsSmartUniversityApi.Models.Domain.DeviceType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorldSkillsSmartUniversityApi.Models.Domain.MacroDevice", b =>
                {
                    b.HasOne("WorldSkillsSmartUniversityApi.Models.Domain.Device", "Device")
                        .WithMany("Macros")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorldSkillsSmartUniversityApi.Models.Domain.Macro", "Macro")
                        .WithMany("Devices")
                        .HasForeignKey("MacroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
