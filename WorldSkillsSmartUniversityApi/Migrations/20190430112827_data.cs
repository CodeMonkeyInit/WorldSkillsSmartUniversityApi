using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldSkillsSmartUniversityApi.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Macros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MacroDevice",
                columns: table => new
                {
                    MacroId = table.Column<int>(nullable: false),
                    DeviceId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacroDevice", x => new { x.MacroId, x.DeviceId });
                    table.ForeignKey(
                        name: "FK_MacroDevice_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MacroDevice_Macros_MacroId",
                        column: x => x.MacroId,
                        principalTable: "Macros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo" },
                values: new object[] { -1, "Г-511", "image.png" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { -1, "WordSkills1337", "WorldSkills" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "Value" },
                values: new object[] { -1, "Люстра", -1, 1, "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "Value" },
                values: new object[] { -2, "Окно", -1, 4, "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "Value" },
                values: new object[] { -3, "Кондиционер", -1, 3, "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "Value" },
                values: new object[] { -4, "Датчик температуры", -1, 6, "+20" });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_RoomId",
                table: "Devices",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_MacroDevice_DeviceId",
                table: "MacroDevice",
                column: "DeviceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MacroDevice");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Macros");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
