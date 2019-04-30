using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldSkillsSmartUniversityApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Macros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Macros_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
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
                    Value = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Devices_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Username",
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
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws1", "028c08" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo23", "a78423" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo24", "436f22" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo25", "351e5c" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo26", "54f71e" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo27", "285d66" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo28", "a5ad3b" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo29", "e63dfb" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo22", "baa2c9" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo30", "11fa98" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo32", "ce9234" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo33", "384007" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo34", "fb5128" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo35", "70cfaf" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo36", "c9c9dc" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo37", "89b597" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo38", "95c551" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo31", "6d2b24" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo21", "2a3a75" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws20", "94a18a" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws19", "7431ee" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws2", "b1f6f3" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws3", "0ad676" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws4", "23417c" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws5", "3c1575" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws6", "a935cb" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws7", "0167ad" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws8", "d21d6a" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws9", "b3d3a1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws10", "91df37" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws11", "6668b5" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws12", "b5325f" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws13", "9791c5" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws14", "f51c62" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws15", "fd7240" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws16", "105703" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws17", "c24921" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws18", "97b28b" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo39", "254202" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo40", "b92680" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -1, "Г-511", "image.png", "ws1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -23, "Г-511", "image.png", "demo23" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -24, "Г-511", "image.png", "demo24" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -25, "Г-511", "image.png", "demo25" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -26, "Г-511", "image.png", "demo26" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -27, "Г-511", "image.png", "demo27" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -28, "Г-511", "image.png", "demo28" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -29, "Г-511", "image.png", "demo29" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -22, "Г-511", "image.png", "demo22" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -30, "Г-511", "image.png", "demo30" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -32, "Г-511", "image.png", "demo32" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -33, "Г-511", "image.png", "demo33" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -34, "Г-511", "image.png", "demo34" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -35, "Г-511", "image.png", "demo35" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -36, "Г-511", "image.png", "demo36" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -37, "Г-511", "image.png", "demo37" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -38, "Г-511", "image.png", "demo38" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -31, "Г-511", "image.png", "demo31" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -21, "Г-511", "image.png", "demo21" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -20, "Г-511", "image.png", "ws20" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -19, "Г-511", "image.png", "ws19" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -2, "Г-511", "image.png", "ws2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -3, "Г-511", "image.png", "ws3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -4, "Г-511", "image.png", "ws4" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -5, "Г-511", "image.png", "ws5" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -6, "Г-511", "image.png", "ws6" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -7, "Г-511", "image.png", "ws7" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -8, "Г-511", "image.png", "ws8" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -9, "Г-511", "image.png", "ws9" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -10, "Г-511", "image.png", "ws10" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -11, "Г-511", "image.png", "ws11" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -12, "Г-511", "image.png", "ws12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -13, "Г-511", "image.png", "ws13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -14, "Г-511", "image.png", "ws14" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -15, "Г-511", "image.png", "ws15" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -16, "Г-511", "image.png", "ws16" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -17, "Г-511", "image.png", "ws17" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -18, "Г-511", "image.png", "ws18" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -39, "Г-511", "image.png", "demo39" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -40, "Г-511", "image.png", "demo40" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -4, "Люстра", -1, 1, "ws1", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -127, "Кондиционер", -26, 3, "demo26", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -126, "Датчик температуры", -26, 6, "demo26", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -134, "Люстра", -27, 1, "demo27", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -133, "Окно", -27, 4, "demo27", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -132, "Кондиционер", -27, 3, "demo27", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -131, "Датчик температуры", -27, 6, "demo27", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -139, "Люстра", -28, 1, "demo28", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -128, "Окно", -26, 4, "demo26", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -138, "Окно", -28, 4, "demo28", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -136, "Датчик температуры", -28, 6, "demo28", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -144, "Люстра", -29, 1, "demo29", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -143, "Окно", -29, 4, "demo29", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -142, "Кондиционер", -29, 3, "demo29", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -141, "Датчик температуры", -29, 6, "demo29", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -149, "Люстра", -30, 1, "demo30", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -148, "Окно", -30, 4, "demo30", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -137, "Кондиционер", -28, 3, "demo28", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -147, "Кондиционер", -30, 3, "demo30", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -129, "Люстра", -26, 1, "demo26", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -122, "Кондиционер", -25, 3, "demo25", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -102, "Кондиционер", -21, 3, "demo21", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -101, "Датчик температуры", -21, 6, "demo21", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -109, "Люстра", -22, 1, "demo22", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -108, "Окно", -22, 4, "demo22", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -107, "Кондиционер", -22, 3, "demo22", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -106, "Датчик температуры", -22, 6, "demo22", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -114, "Люстра", -23, 1, "demo23", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -121, "Датчик температуры", -25, 6, "demo25", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -113, "Окно", -23, 4, "demo23", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -111, "Датчик температуры", -23, 6, "demo23", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -119, "Люстра", -24, 1, "demo24", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -118, "Окно", -24, 4, "demo24", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -117, "Кондиционер", -24, 3, "demo24", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -116, "Датчик температуры", -24, 6, "demo24", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -124, "Люстра", -25, 1, "demo25", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -123, "Окно", -25, 4, "demo25", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -112, "Кондиционер", -23, 3, "demo23", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -103, "Окно", -21, 4, "demo21", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -146, "Датчик температуры", -30, 6, "demo30", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -153, "Окно", -31, 4, "demo31", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -177, "Кондиционер", -36, 3, "demo36", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -176, "Датчик температуры", -36, 6, "demo36", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -184, "Люстра", -37, 1, "demo37", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -183, "Окно", -37, 4, "demo37", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -182, "Кондиционер", -37, 3, "demo37", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -181, "Датчик температуры", -37, 6, "demo37", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -189, "Люстра", -38, 1, "demo38", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -178, "Окно", -36, 4, "demo36", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -188, "Окно", -38, 4, "demo38", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -186, "Датчик температуры", -38, 6, "demo38", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -194, "Люстра", -39, 1, "demo39", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -193, "Окно", -39, 4, "demo39", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -192, "Кондиционер", -39, 3, "demo39", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -191, "Датчик температуры", -39, 6, "demo39", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -199, "Люстра", -40, 1, "demo40", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -198, "Окно", -40, 4, "demo40", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -187, "Кондиционер", -38, 3, "demo38", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -154, "Люстра", -31, 1, "demo31", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -179, "Люстра", -36, 1, "demo36", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -172, "Кондиционер", -35, 3, "demo35", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -152, "Кондиционер", -31, 3, "demo31", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -151, "Датчик температуры", -31, 6, "demo31", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -159, "Люстра", -32, 1, "demo32", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -158, "Окно", -32, 4, "demo32", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -157, "Кондиционер", -32, 3, "demo32", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -156, "Датчик температуры", -32, 6, "demo32", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -164, "Люстра", -33, 1, "demo33", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -171, "Датчик температуры", -35, 6, "demo35", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -163, "Окно", -33, 4, "demo33", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -161, "Датчик температуры", -33, 6, "demo33", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -169, "Люстра", -34, 1, "demo34", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -168, "Окно", -34, 4, "demo34", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -167, "Кондиционер", -34, 3, "demo34", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -166, "Датчик температуры", -34, 6, "demo34", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -174, "Люстра", -35, 1, "demo35", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -173, "Окно", -35, 4, "demo35", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -162, "Кондиционер", -33, 3, "demo33", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -104, "Люстра", -21, 1, "demo21", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -96, "Датчик температуры", -20, 6, "ws20", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -97, "Кондиционер", -20, 3, "ws20", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -28, "Окно", -6, 4, "ws6", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -27, "Кондиционер", -6, 3, "ws6", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -26, "Датчик температуры", -6, 6, "ws6", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -34, "Люстра", -7, 1, "ws7", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -33, "Окно", -7, 4, "ws7", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -32, "Кондиционер", -7, 3, "ws7", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -31, "Датчик температуры", -7, 6, "ws7", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -29, "Люстра", -6, 1, "ws6", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -39, "Люстра", -8, 1, "ws8", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -37, "Кондиционер", -8, 3, "ws8", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -36, "Датчик температуры", -8, 6, "ws8", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -44, "Люстра", -9, 1, "ws9", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -43, "Окно", -9, 4, "ws9", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -42, "Кондиционер", -9, 3, "ws9", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -41, "Датчик температуры", -9, 6, "ws9", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -49, "Люстра", -10, 1, "ws10", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -38, "Окно", -8, 4, "ws8", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -48, "Окно", -10, 4, "ws10", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -21, "Датчик температуры", -5, 6, "ws5", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -23, "Окно", -5, 4, "ws5", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -3, "Окно", -1, 4, "ws1", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -2, "Кондиционер", -1, 3, "ws1", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -1, "Датчик температуры", -1, 6, "ws1", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -9, "Люстра", -2, 1, "ws2", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -8, "Окно", -2, 4, "ws2", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -7, "Кондиционер", -2, 3, "ws2", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -6, "Датчик температуры", -2, 6, "ws2", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -22, "Кондиционер", -5, 3, "ws5", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -14, "Люстра", -3, 1, "ws3", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -12, "Кондиционер", -3, 3, "ws3", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -11, "Датчик температуры", -3, 6, "ws3", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -19, "Люстра", -4, 1, "ws4", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -18, "Окно", -4, 4, "ws4", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -17, "Кондиционер", -4, 3, "ws4", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -16, "Датчик температуры", -4, 6, "ws4", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -24, "Люстра", -5, 1, "ws5", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -13, "Окно", -3, 4, "ws3", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -47, "Кондиционер", -10, 3, "ws10", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -46, "Датчик температуры", -10, 6, "ws10", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -54, "Люстра", -11, 1, "ws11", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -77, "Кондиционер", -16, 3, "ws16", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -76, "Датчик температуры", -16, 6, "ws16", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -84, "Люстра", -17, 1, "ws17", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -83, "Окно", -17, 4, "ws17", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -82, "Кондиционер", -17, 3, "ws17", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -81, "Датчик температуры", -17, 6, "ws17", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -89, "Люстра", -18, 1, "ws18", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -78, "Окно", -16, 4, "ws16", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -88, "Окно", -18, 4, "ws18", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -86, "Датчик температуры", -18, 6, "ws18", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -94, "Люстра", -19, 1, "ws19", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -93, "Окно", -19, 4, "ws19", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -92, "Кондиционер", -19, 3, "ws19", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -91, "Датчик температуры", -19, 6, "ws19", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -99, "Люстра", -20, 1, "ws20", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -98, "Окно", -20, 4, "ws20", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -87, "Кондиционер", -18, 3, "ws18", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -79, "Люстра", -16, 1, "ws16", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -71, "Датчик температуры", -15, 6, "ws15", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -72, "Кондиционер", -15, 3, "ws15", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -53, "Окно", -11, 4, "ws11", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -52, "Кондиционер", -11, 3, "ws11", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -51, "Датчик температуры", -11, 6, "ws11", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -59, "Люстра", -12, 1, "ws12", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -58, "Окно", -12, 4, "ws12", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -57, "Кондиционер", -12, 3, "ws12", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -56, "Датчик температуры", -12, 6, "ws12", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -64, "Люстра", -13, 1, "ws13", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -63, "Окно", -13, 4, "ws13", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -62, "Кондиционер", -13, 3, "ws13", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -61, "Датчик температуры", -13, 6, "ws13", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -69, "Люстра", -14, 1, "ws14", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -68, "Окно", -14, 4, "ws14", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -67, "Кондиционер", -14, 3, "ws14", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -66, "Датчик температуры", -14, 6, "ws14", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -74, "Люстра", -15, 1, "ws15", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -73, "Окно", -15, 4, "ws15", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -197, "Кондиционер", -40, 3, "demo40", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { -196, "Датчик температуры", -40, 6, "demo40", "+20" });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_RoomId",
                table: "Devices",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_UserId",
                table: "Devices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MacroDevice_DeviceId",
                table: "MacroDevice",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Macros_Username",
                table: "Macros",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_UserId",
                table: "Rooms",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MacroDevice");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Macros");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
