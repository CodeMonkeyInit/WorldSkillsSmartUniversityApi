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
                    UserId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Macros_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
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
                    UserId = table.Column<string>(nullable: false),
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
                values: new object[] { "ws1", "696932" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo23", "07c20d" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo24", "4636b2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo25", "95c4c7" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo26", "ce0224" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo27", "76d562" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo28", "d78cb5" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo29", "123132" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo22", "d0cb47" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo30", "2000b8" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo32", "0cfcb6" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo33", "d363de" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo34", "98acd8" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo35", "03b6a6" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo36", "84e7a1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo37", "513c09" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo38", "4ba9ca" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo31", "71d853" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo21", "eba2b4" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws20", "513dab" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws19", "9e487e" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws2", "684927" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws3", "b8abdc" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws4", "c7f043" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws5", "d11264" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws6", "79720d" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws7", "6492e4" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws8", "de5e42" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws9", "92f67f" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws10", "cb6149" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws11", "f492b4" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws12", "464476" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws13", "12451b" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws14", "8c32d5" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws15", "a4a516" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws16", "5b4020" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws17", "5c4a5e" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "ws18", "fdaf25" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo39", "d5f800" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Password" },
                values: new object[] { "demo40", "c11ef7" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -10, "Г-10", "images/room0.png", "ws1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -258, "Г-258", "images/room2.png", "demo26" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -257, "Г-257", "images/room3.png", "demo26" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -256, "Г-256", "images/room4.png", "demo26" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -255, "Г-255", "images/room5.png", "demo26" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -270, "Г-270", "images/room0.png", "demo27" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -269, "Г-269", "images/room1.png", "demo27" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -268, "Г-268", "images/room2.png", "demo27" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -267, "Г-267", "images/room3.png", "demo27" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -266, "Г-266", "images/room4.png", "demo27" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -265, "Г-265", "images/room5.png", "demo27" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -280, "Г-280", "images/room0.png", "demo28" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -279, "Г-279", "images/room1.png", "demo28" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -259, "Г-259", "images/room1.png", "demo26" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -278, "Г-278", "images/room2.png", "demo28" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -276, "Г-276", "images/room4.png", "demo28" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -275, "Г-275", "images/room5.png", "demo28" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -290, "Г-290", "images/room0.png", "demo29" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -289, "Г-289", "images/room1.png", "demo29" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -288, "Г-288", "images/room2.png", "demo29" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -287, "Г-287", "images/room3.png", "demo29" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -286, "Г-286", "images/room4.png", "demo29" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -285, "Г-285", "images/room5.png", "demo29" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -300, "Г-300", "images/room0.png", "demo30" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -299, "Г-299", "images/room1.png", "demo30" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -298, "Г-298", "images/room2.png", "demo30" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -297, "Г-297", "images/room3.png", "demo30" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -277, "Г-277", "images/room3.png", "demo28" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -296, "Г-296", "images/room4.png", "demo30" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -260, "Г-260", "images/room0.png", "demo26" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -246, "Г-246", "images/room4.png", "demo25" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -208, "Г-208", "images/room2.png", "demo21" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -207, "Г-207", "images/room3.png", "demo21" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -206, "Г-206", "images/room4.png", "demo21" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -205, "Г-205", "images/room5.png", "demo21" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -220, "Г-220", "images/room0.png", "demo22" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -219, "Г-219", "images/room1.png", "demo22" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -218, "Г-218", "images/room2.png", "demo22" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -217, "Г-217", "images/room3.png", "demo22" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -216, "Г-216", "images/room4.png", "demo22" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -215, "Г-215", "images/room5.png", "demo22" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -230, "Г-230", "images/room0.png", "demo23" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -229, "Г-229", "images/room1.png", "demo23" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -245, "Г-245", "images/room5.png", "demo25" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -228, "Г-228", "images/room2.png", "demo23" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -226, "Г-226", "images/room4.png", "demo23" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -225, "Г-225", "images/room5.png", "demo23" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -240, "Г-240", "images/room0.png", "demo24" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -239, "Г-239", "images/room1.png", "demo24" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -238, "Г-238", "images/room2.png", "demo24" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -237, "Г-237", "images/room3.png", "demo24" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -236, "Г-236", "images/room4.png", "demo24" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -235, "Г-235", "images/room5.png", "demo24" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -250, "Г-250", "images/room0.png", "demo25" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -249, "Г-249", "images/room1.png", "demo25" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -248, "Г-248", "images/room2.png", "demo25" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -247, "Г-247", "images/room3.png", "demo25" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -227, "Г-227", "images/room3.png", "demo23" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -209, "Г-209", "images/room1.png", "demo21" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -295, "Г-295", "images/room5.png", "demo30" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -309, "Г-309", "images/room1.png", "demo31" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -358, "Г-358", "images/room2.png", "demo36" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -357, "Г-357", "images/room3.png", "demo36" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -356, "Г-356", "images/room4.png", "demo36" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -355, "Г-355", "images/room5.png", "demo36" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -370, "Г-370", "images/room0.png", "demo37" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -369, "Г-369", "images/room1.png", "demo37" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -368, "Г-368", "images/room2.png", "demo37" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -367, "Г-367", "images/room3.png", "demo37" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -366, "Г-366", "images/room4.png", "demo37" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -365, "Г-365", "images/room5.png", "demo37" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -380, "Г-380", "images/room0.png", "demo38" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -379, "Г-379", "images/room1.png", "demo38" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -359, "Г-359", "images/room1.png", "demo36" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -378, "Г-378", "images/room2.png", "demo38" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -376, "Г-376", "images/room4.png", "demo38" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -375, "Г-375", "images/room5.png", "demo38" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -390, "Г-390", "images/room0.png", "demo39" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -389, "Г-389", "images/room1.png", "demo39" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -388, "Г-388", "images/room2.png", "demo39" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -387, "Г-387", "images/room3.png", "demo39" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -386, "Г-386", "images/room4.png", "demo39" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -385, "Г-385", "images/room5.png", "demo39" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -400, "Г-400", "images/room0.png", "demo40" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -399, "Г-399", "images/room1.png", "demo40" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -398, "Г-398", "images/room2.png", "demo40" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -397, "Г-397", "images/room3.png", "demo40" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -377, "Г-377", "images/room3.png", "demo38" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -310, "Г-310", "images/room0.png", "demo31" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -360, "Г-360", "images/room0.png", "demo36" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -346, "Г-346", "images/room4.png", "demo35" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -308, "Г-308", "images/room2.png", "demo31" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -307, "Г-307", "images/room3.png", "demo31" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -306, "Г-306", "images/room4.png", "demo31" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -305, "Г-305", "images/room5.png", "demo31" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -320, "Г-320", "images/room0.png", "demo32" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -319, "Г-319", "images/room1.png", "demo32" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -318, "Г-318", "images/room2.png", "demo32" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -317, "Г-317", "images/room3.png", "demo32" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -316, "Г-316", "images/room4.png", "demo32" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -315, "Г-315", "images/room5.png", "demo32" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -330, "Г-330", "images/room0.png", "demo33" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -329, "Г-329", "images/room1.png", "demo33" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -345, "Г-345", "images/room5.png", "demo35" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -328, "Г-328", "images/room2.png", "demo33" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -326, "Г-326", "images/room4.png", "demo33" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -325, "Г-325", "images/room5.png", "demo33" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -340, "Г-340", "images/room0.png", "demo34" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -339, "Г-339", "images/room1.png", "demo34" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -338, "Г-338", "images/room2.png", "demo34" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -337, "Г-337", "images/room3.png", "demo34" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -336, "Г-336", "images/room4.png", "demo34" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -335, "Г-335", "images/room5.png", "demo34" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -350, "Г-350", "images/room0.png", "demo35" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -349, "Г-349", "images/room1.png", "demo35" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -348, "Г-348", "images/room2.png", "demo35" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -347, "Г-347", "images/room3.png", "demo35" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -327, "Г-327", "images/room3.png", "demo33" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -210, "Г-210", "images/room0.png", "demo21" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -195, "Г-195", "images/room5.png", "ws20" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -196, "Г-196", "images/room4.png", "ws20" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -59, "Г-59", "images/room1.png", "ws6" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -58, "Г-58", "images/room2.png", "ws6" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -57, "Г-57", "images/room3.png", "ws6" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -56, "Г-56", "images/room4.png", "ws6" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -55, "Г-55", "images/room5.png", "ws6" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -70, "Г-70", "images/room0.png", "ws7" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -69, "Г-69", "images/room1.png", "ws7" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -68, "Г-68", "images/room2.png", "ws7" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -67, "Г-67", "images/room3.png", "ws7" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -66, "Г-66", "images/room4.png", "ws7" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -65, "Г-65", "images/room5.png", "ws7" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -80, "Г-80", "images/room0.png", "ws8" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -60, "Г-60", "images/room0.png", "ws6" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -79, "Г-79", "images/room1.png", "ws8" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -77, "Г-77", "images/room3.png", "ws8" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -76, "Г-76", "images/room4.png", "ws8" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -75, "Г-75", "images/room5.png", "ws8" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -90, "Г-90", "images/room0.png", "ws9" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -89, "Г-89", "images/room1.png", "ws9" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -88, "Г-88", "images/room2.png", "ws9" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -87, "Г-87", "images/room3.png", "ws9" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -86, "Г-86", "images/room4.png", "ws9" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -85, "Г-85", "images/room5.png", "ws9" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -100, "Г-100", "images/room0.png", "ws10" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -99, "Г-99", "images/room1.png", "ws10" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -98, "Г-98", "images/room2.png", "ws10" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -78, "Г-78", "images/room2.png", "ws8" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -97, "Г-97", "images/room3.png", "ws10" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -45, "Г-45", "images/room5.png", "ws5" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -47, "Г-47", "images/room3.png", "ws5" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -9, "Г-9", "images/room1.png", "ws1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -8, "Г-8", "images/room2.png", "ws1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -7, "Г-7", "images/room3.png", "ws1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -6, "Г-6", "images/room4.png", "ws1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -5, "Г-5", "images/room5.png", "ws1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -20, "Г-20", "images/room0.png", "ws2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -19, "Г-19", "images/room1.png", "ws2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -18, "Г-18", "images/room2.png", "ws2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -17, "Г-17", "images/room3.png", "ws2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -16, "Г-16", "images/room4.png", "ws2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -15, "Г-15", "images/room5.png", "ws2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -30, "Г-30", "images/room0.png", "ws3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -46, "Г-46", "images/room4.png", "ws5" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -29, "Г-29", "images/room1.png", "ws3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -27, "Г-27", "images/room3.png", "ws3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -26, "Г-26", "images/room4.png", "ws3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -25, "Г-25", "images/room5.png", "ws3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -40, "Г-40", "images/room0.png", "ws4" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -39, "Г-39", "images/room1.png", "ws4" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -38, "Г-38", "images/room2.png", "ws4" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -37, "Г-37", "images/room3.png", "ws4" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -36, "Г-36", "images/room4.png", "ws4" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -35, "Г-35", "images/room5.png", "ws4" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -50, "Г-50", "images/room0.png", "ws5" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -49, "Г-49", "images/room1.png", "ws5" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -48, "Г-48", "images/room2.png", "ws5" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -28, "Г-28", "images/room2.png", "ws3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -96, "Г-96", "images/room4.png", "ws10" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -95, "Г-95", "images/room5.png", "ws10" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -110, "Г-110", "images/room0.png", "ws11" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -158, "Г-158", "images/room2.png", "ws16" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -157, "Г-157", "images/room3.png", "ws16" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -156, "Г-156", "images/room4.png", "ws16" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -155, "Г-155", "images/room5.png", "ws16" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -170, "Г-170", "images/room0.png", "ws17" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -169, "Г-169", "images/room1.png", "ws17" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -168, "Г-168", "images/room2.png", "ws17" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -167, "Г-167", "images/room3.png", "ws17" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -166, "Г-166", "images/room4.png", "ws17" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -165, "Г-165", "images/room5.png", "ws17" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -180, "Г-180", "images/room0.png", "ws18" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -179, "Г-179", "images/room1.png", "ws18" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -159, "Г-159", "images/room1.png", "ws16" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -178, "Г-178", "images/room2.png", "ws18" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -176, "Г-176", "images/room4.png", "ws18" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -175, "Г-175", "images/room5.png", "ws18" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -190, "Г-190", "images/room0.png", "ws19" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -189, "Г-189", "images/room1.png", "ws19" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -188, "Г-188", "images/room2.png", "ws19" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -187, "Г-187", "images/room3.png", "ws19" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -186, "Г-186", "images/room4.png", "ws19" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -185, "Г-185", "images/room5.png", "ws19" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -200, "Г-200", "images/room0.png", "ws20" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -199, "Г-199", "images/room1.png", "ws20" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -198, "Г-198", "images/room2.png", "ws20" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -197, "Г-197", "images/room3.png", "ws20" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -177, "Г-177", "images/room3.png", "ws18" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -160, "Г-160", "images/room0.png", "ws16" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -145, "Г-145", "images/room5.png", "ws15" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -146, "Г-146", "images/room4.png", "ws15" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -109, "Г-109", "images/room1.png", "ws11" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -108, "Г-108", "images/room2.png", "ws11" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -107, "Г-107", "images/room3.png", "ws11" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -106, "Г-106", "images/room4.png", "ws11" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -105, "Г-105", "images/room5.png", "ws11" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -120, "Г-120", "images/room0.png", "ws12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -119, "Г-119", "images/room1.png", "ws12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -118, "Г-118", "images/room2.png", "ws12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -117, "Г-117", "images/room3.png", "ws12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -116, "Г-116", "images/room4.png", "ws12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -115, "Г-115", "images/room5.png", "ws12" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -130, "Г-130", "images/room0.png", "ws13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -129, "Г-129", "images/room1.png", "ws13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -128, "Г-128", "images/room2.png", "ws13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -127, "Г-127", "images/room3.png", "ws13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -126, "Г-126", "images/room4.png", "ws13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -125, "Г-125", "images/room5.png", "ws13" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -140, "Г-140", "images/room0.png", "ws14" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -139, "Г-139", "images/room1.png", "ws14" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -138, "Г-138", "images/room2.png", "ws14" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -137, "Г-137", "images/room3.png", "ws14" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -136, "Г-136", "images/room4.png", "ws14" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -135, "Г-135", "images/room5.png", "ws14" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -150, "Г-150", "images/room0.png", "ws15" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -149, "Г-149", "images/room1.png", "ws15" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -148, "Г-148", "images/room2.png", "ws15" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -147, "Г-147", "images/room3.png", "ws15" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -396, "Г-396", "images/room4.png", "demo40" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo", "UserId" },
                values: new object[] { -395, "Г-395", "images/room5.png", "demo40" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 103, "Датчик температуры", -10, 6, "ws1", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72361, "Окно", -268, 4, "demo27", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72365, "Дверь", -268, 2, "demo27", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72090, "Люстра", -267, 1, "demo27", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72094, "Увлажнитель", -267, 5, "demo27", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72092, "Кондиционер", -267, 3, "demo27", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 71825, "Дверь", -266, 2, "demo27", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 71821, "Окно", -266, 4, "demo27", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 71823, "Датчик температуры", -266, 6, "demo27", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72363, "Датчик температуры", -268, 6, "demo27", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 71552, "Кондиционер", -265, 3, "demo27", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 71554, "Увлажнитель", -265, 5, "demo27", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 78403, "Датчик температуры", -280, 6, "demo28", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 78405, "Дверь", -280, 2, "demo28", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 78401, "Окно", -280, 4, "demo28", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 78122, "Кондиционер", -279, 3, "demo28", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 78124, "Увлажнитель", -279, 5, "demo28", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 78120, "Люстра", -279, 1, "demo28", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77843, "Датчик температуры", -278, 6, "demo28", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 71550, "Люстра", -265, 1, "demo27", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72632, "Кондиционер", -269, 3, "demo27", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72630, "Люстра", -269, 1, "demo27", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72634, "Увлажнитель", -269, 5, "demo27", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 67605, "Дверь", -260, 2, "demo26", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 67340, "Люстра", -259, 1, "demo26", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 67344, "Увлажнитель", -259, 5, "demo26", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 67342, "Кондиционер", -259, 3, "demo26", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 67081, "Окно", -258, 4, "demo26", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 67083, "Датчик температуры", -258, 6, "demo26", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 67085, "Дверь", -258, 2, "demo26", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 66820, "Люстра", -257, 1, "demo26", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 66822, "Кондиционер", -257, 3, "demo26", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 66824, "Увлажнитель", -257, 5, "demo26", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 66561, "Окно", -256, 4, "demo26", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 66565, "Дверь", -256, 2, "demo26", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 66563, "Датчик температуры", -256, 6, "demo26", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 66300, "Люстра", -255, 1, "demo26", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 66302, "Кондиционер", -255, 3, "demo26", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 66304, "Увлажнитель", -255, 5, "demo26", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72905, "Дверь", -270, 2, "demo27", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72903, "Датчик температуры", -270, 6, "demo27", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72901, "Окно", -270, 4, "demo27", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77845, "Дверь", -278, 2, "demo28", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 67601, "Окно", -260, 4, "demo26", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77841, "Окно", -278, 4, "demo28", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77562, "Кондиционер", -277, 3, "demo28", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 82650, "Люстра", -285, 1, "demo29", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 82654, "Увлажнитель", -285, 5, "demo29", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 90003, "Датчик температуры", -300, 6, "demo30", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 90001, "Окно", -300, 4, "demo30", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 90005, "Дверь", -300, 2, "demo30", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 89700, "Люстра", -299, 1, "demo30", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 89702, "Кондиционер", -299, 3, "demo30", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 89704, "Увлажнитель", -299, 5, "demo30", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 82652, "Кондиционер", -285, 3, "demo29", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 89403, "Датчик температуры", -298, 6, "demo30", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 89405, "Дверь", -298, 2, "demo30", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 89102, "Кондиционер", -297, 3, "demo30", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 89104, "Увлажнитель", -297, 5, "demo30", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 89100, "Люстра", -297, 1, "demo30", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 88803, "Датчик температуры", -296, 6, "demo30", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 88805, "Дверь", -296, 2, "demo30", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 88801, "Окно", -296, 4, "demo30", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 88502, "Кондиционер", -295, 3, "demo30", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 89401, "Окно", -298, 4, "demo30", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 82943, "Датчик температуры", -286, 6, "demo29", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 82941, "Окно", -286, 4, "demo29", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 82945, "Дверь", -286, 2, "demo29", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77560, "Люстра", -277, 1, "demo28", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77283, "Датчик температуры", -276, 6, "demo28", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77285, "Дверь", -276, 2, "demo28", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77281, "Окно", -276, 4, "demo28", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77004, "Увлажнитель", -275, 5, "demo28", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77002, "Кондиционер", -275, 3, "demo28", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77000, "Люстра", -275, 1, "demo28", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 84105, "Дверь", -290, 2, "demo29", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 84103, "Датчик температуры", -290, 6, "demo29", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 84101, "Окно", -290, 4, "demo29", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83812, "Кондиционер", -289, 3, "demo29", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83810, "Люстра", -289, 1, "demo29", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83814, "Увлажнитель", -289, 5, "demo29", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83525, "Дверь", -288, 2, "demo29", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83523, "Датчик температуры", -288, 6, "demo29", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83521, "Окно", -288, 4, "demo29", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83232, "Кондиционер", -287, 3, "demo29", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83234, "Увлажнитель", -287, 5, "demo29", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83230, "Люстра", -287, 1, "demo29", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 77564, "Увлажнитель", -277, 5, "demo28", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 88504, "Увлажнитель", -295, 5, "demo30", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 67603, "Датчик температуры", -260, 6, "demo26", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61250, "Люстра", -245, 1, "demo25", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47961, "Окно", -218, 4, "demo22", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47965, "Дверь", -218, 2, "demo22", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47740, "Люстра", -217, 1, "demo22", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47744, "Увлажнитель", -217, 5, "demo22", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47742, "Кондиционер", -217, 3, "demo22", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47521, "Окно", -216, 4, "demo22", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47523, "Датчик температуры", -216, 6, "demo22", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47525, "Дверь", -216, 2, "demo22", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47963, "Датчик температуры", -218, 6, "demo22", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47300, "Люстра", -215, 1, "demo22", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47304, "Увлажнитель", -215, 5, "demo22", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52901, "Окно", -230, 4, "demo23", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52905, "Дверь", -230, 2, "demo23", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52903, "Датчик температуры", -230, 6, "demo23", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52670, "Люстра", -229, 1, "demo23", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52672, "Кондиционер", -229, 3, "demo23", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52674, "Увлажнитель", -229, 5, "demo23", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52443, "Датчик температуры", -228, 6, "demo23", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 47302, "Кондиционер", -215, 3, "demo22", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 48182, "Кондиционер", -219, 3, "demo22", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 48184, "Увлажнитель", -219, 5, "demo22", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 48180, "Люстра", -219, 1, "demo22", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 44103, "Датчик температуры", -210, 6, "demo21", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43890, "Люстра", -209, 1, "demo21", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43892, "Кондиционер", -209, 3, "demo21", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43894, "Увлажнитель", -209, 5, "demo21", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43681, "Окно", -208, 4, "demo21", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43683, "Датчик температуры", -208, 6, "demo21", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43685, "Дверь", -208, 2, "demo21", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43472, "Кондиционер", -207, 3, "demo21", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43474, "Увлажнитель", -207, 5, "demo21", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43470, "Люстра", -207, 1, "demo21", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43263, "Датчик температуры", -206, 6, "demo21", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43261, "Окно", -206, 4, "demo21", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43265, "Дверь", -206, 2, "demo21", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43054, "Увлажнитель", -205, 5, "demo21", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43050, "Люстра", -205, 1, "demo21", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 43052, "Кондиционер", -205, 3, "demo21", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 48405, "Дверь", -220, 2, "demo22", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 48403, "Датчик температуры", -220, 6, "demo22", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 48401, "Окно", -220, 4, "demo22", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52441, "Окно", -228, 4, "demo23", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61254, "Увлажнитель", -245, 5, "demo25", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52445, "Дверь", -228, 2, "demo23", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52212, "Кондиционер", -227, 3, "demo23", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 56402, "Кондиционер", -235, 3, "demo24", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 56400, "Люстра", -235, 1, "demo24", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 62503, "Датчик температуры", -250, 6, "demo25", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 62505, "Дверь", -250, 2, "demo25", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 62501, "Окно", -250, 4, "demo25", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 62250, "Люстра", -249, 1, "demo25", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 62252, "Кондиционер", -249, 3, "demo25", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 62254, "Увлажнитель", -249, 5, "demo25", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 56404, "Увлажнитель", -235, 5, "demo24", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 62005, "Дверь", -248, 2, "demo25", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 62003, "Датчик температуры", -248, 6, "demo25", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61750, "Люстра", -247, 1, "demo25", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61754, "Увлажнитель", -247, 5, "demo25", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61752, "Кондиционер", -247, 3, "demo25", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61503, "Датчик температуры", -246, 6, "demo25", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61505, "Дверь", -246, 2, "demo25", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61501, "Окно", -246, 4, "demo25", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61252, "Кондиционер", -245, 3, "demo25", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 62001, "Окно", -248, 4, "demo25", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 56645, "Дверь", -236, 2, "demo24", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 56643, "Датчик температуры", -236, 6, "demo24", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 56641, "Окно", -236, 4, "demo24", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52214, "Увлажнитель", -227, 5, "demo23", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 51985, "Дверь", -226, 2, "demo23", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 51981, "Окно", -226, 4, "demo23", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 51983, "Датчик температуры", -226, 6, "demo23", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 51750, "Люстра", -225, 1, "demo23", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 51754, "Увлажнитель", -225, 5, "demo23", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 51752, "Кондиционер", -225, 3, "demo23", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 57601, "Окно", -240, 4, "demo24", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 57603, "Датчик температуры", -240, 6, "demo24", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 57605, "Дверь", -240, 2, "demo24", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 57360, "Люстра", -239, 1, "demo24", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 57362, "Кондиционер", -239, 3, "demo24", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 57364, "Увлажнитель", -239, 5, "demo24", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 57125, "Дверь", -238, 2, "demo24", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 57121, "Окно", -238, 4, "demo24", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 57123, "Датчик температуры", -238, 6, "demo24", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 56884, "Увлажнитель", -237, 5, "demo24", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 56880, "Люстра", -237, 1, "demo24", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 56882, "Кондиционер", -237, 3, "demo24", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52210, "Люстра", -227, 1, "demo23", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 44105, "Дверь", -210, 2, "demo21", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 88500, "Люстра", -295, 1, "demo30", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 96103, "Датчик температуры", -310, 6, "demo31", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 136161, "Окно", -368, 4, "demo37", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 136163, "Датчик температуры", -368, 6, "demo37", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 135794, "Увлажнитель", -367, 5, "demo37", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 135792, "Кондиционер", -367, 3, "demo37", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 135790, "Люстра", -367, 1, "demo37", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 135425, "Дверь", -366, 2, "demo37", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 135421, "Окно", -366, 4, "demo37", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 135423, "Датчик температуры", -366, 6, "demo37", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 136165, "Дверь", -368, 2, "demo37", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 135054, "Увлажнитель", -365, 5, "demo37", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 135050, "Люстра", -365, 1, "demo37", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 144405, "Дверь", -380, 2, "demo38", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 144401, "Окно", -380, 4, "demo38", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 144403, "Датчик температуры", -380, 6, "demo38", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 144024, "Увлажнитель", -379, 5, "demo38", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 144020, "Люстра", -379, 1, "demo38", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 144022, "Кондиционер", -379, 3, "demo38", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 143645, "Дверь", -378, 2, "demo38", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 135052, "Кондиционер", -365, 3, "demo37", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 136532, "Кондиционер", -369, 3, "demo37", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 136530, "Люстра", -369, 1, "demo37", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 136534, "Увлажнитель", -369, 5, "demo37", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 129601, "Окно", -360, 4, "demo36", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 129240, "Люстра", -359, 1, "demo36", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 129242, "Кондиционер", -359, 3, "demo36", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 129244, "Увлажнитель", -359, 5, "demo36", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 128883, "Датчик температуры", -358, 6, "demo36", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 128881, "Окно", -358, 4, "demo36", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 128885, "Дверь", -358, 2, "demo36", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 128524, "Увлажнитель", -357, 5, "demo36", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 128522, "Кондиционер", -357, 3, "demo36", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 128520, "Люстра", -357, 1, "demo36", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 128161, "Окно", -356, 4, "demo36", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 128163, "Датчик температуры", -356, 6, "demo36", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 128165, "Дверь", -356, 2, "demo36", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 127804, "Увлажнитель", -355, 5, "demo36", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 127802, "Кондиционер", -355, 3, "demo36", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 127800, "Люстра", -355, 1, "demo36", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 136903, "Датчик температуры", -370, 6, "demo37", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 136901, "Окно", -370, 4, "demo37", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 136905, "Дверь", -370, 2, "demo37", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 143641, "Окно", -378, 4, "demo38", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 129605, "Дверь", -360, 2, "demo36", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 143643, "Датчик температуры", -378, 6, "demo38", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 143260, "Люстра", -377, 1, "demo38", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 150152, "Кондиционер", -385, 3, "demo39", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 150150, "Люстра", -385, 1, "demo39", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 160003, "Датчик температуры", -400, 6, "demo40", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 160001, "Окно", -400, 4, "demo40", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 160005, "Дверь", -400, 2, "demo40", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 159604, "Увлажнитель", -399, 5, "demo40", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 159600, "Люстра", -399, 1, "demo40", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 159602, "Кондиционер", -399, 3, "demo40", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 150154, "Увлажнитель", -385, 5, "demo39", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 159201, "Окно", -398, 4, "demo40", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 159205, "Дверь", -398, 2, "demo40", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 158800, "Люстра", -397, 1, "demo40", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 158804, "Увлажнитель", -397, 5, "demo40", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 158802, "Кондиционер", -397, 3, "demo40", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 158401, "Окно", -396, 4, "demo40", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 158405, "Дверь", -396, 2, "demo40", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 158403, "Датчик температуры", -396, 6, "demo40", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 158002, "Кондиционер", -395, 3, "demo40", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 159203, "Датчик температуры", -398, 6, "demo40", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 150545, "Дверь", -386, 2, "demo39", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 150543, "Датчик температуры", -386, 6, "demo39", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 150541, "Окно", -386, 4, "demo39", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 143264, "Увлажнитель", -377, 5, "demo38", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 142883, "Датчик температуры", -376, 6, "demo38", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 142881, "Окно", -376, 4, "demo38", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 142885, "Дверь", -376, 2, "demo38", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 142504, "Увлажнитель", -375, 5, "demo38", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 142502, "Кондиционер", -375, 3, "demo38", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 142500, "Люстра", -375, 1, "demo38", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 152103, "Датчик температуры", -390, 6, "demo39", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 152105, "Дверь", -390, 2, "demo39", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 152101, "Окно", -390, 4, "demo39", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 151714, "Увлажнитель", -389, 5, "demo39", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 151710, "Люстра", -389, 1, "demo39", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 151712, "Кондиционер", -389, 3, "demo39", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 151325, "Дверь", -388, 2, "demo39", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 151321, "Окно", -388, 4, "demo39", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 151323, "Датчик температуры", -388, 6, "demo39", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 150934, "Увлажнитель", -387, 5, "demo39", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 150930, "Люстра", -387, 1, "demo39", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 150932, "Кондиционер", -387, 3, "demo39", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 143262, "Кондиционер", -377, 3, "demo38", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 96105, "Дверь", -310, 2, "demo31", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 129603, "Датчик температуры", -360, 6, "demo36", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 120750, "Люстра", -345, 1, "demo35", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101765, "Дверь", -318, 2, "demo32", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101761, "Окно", -318, 4, "demo32", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101442, "Кондиционер", -317, 3, "demo32", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101444, "Увлажнитель", -317, 5, "demo32", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101440, "Люстра", -317, 1, "demo32", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101123, "Датчик температуры", -316, 6, "demo32", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101121, "Окно", -316, 4, "demo32", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101125, "Дверь", -316, 2, "demo32", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101763, "Датчик температуры", -318, 6, "demo32", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 100800, "Люстра", -315, 1, "demo32", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 100804, "Увлажнитель", -315, 5, "demo32", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 108905, "Дверь", -330, 2, "demo33", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 108903, "Датчик температуры", -330, 6, "demo33", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 108901, "Окно", -330, 4, "demo33", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 108570, "Люстра", -329, 1, "demo33", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 108572, "Кондиционер", -329, 3, "demo33", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 108574, "Увлажнитель", -329, 5, "demo33", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 108243, "Датчик температуры", -328, 6, "demo33", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 100802, "Кондиционер", -315, 3, "demo32", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 102082, "Кондиционер", -319, 3, "demo32", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 102080, "Люстра", -319, 1, "demo32", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 102084, "Увлажнитель", -319, 5, "demo32", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 96101, "Окно", -310, 4, "demo31", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 95790, "Люстра", -309, 1, "demo31", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 95792, "Кондиционер", -309, 3, "demo31", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 95794, "Увлажнитель", -309, 5, "demo31", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 95481, "Окно", -308, 4, "demo31", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 95483, "Датчик температуры", -308, 6, "demo31", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 95485, "Дверь", -308, 2, "demo31", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 95174, "Увлажнитель", -307, 5, "demo31", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 95172, "Кондиционер", -307, 3, "demo31", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 95170, "Люстра", -307, 1, "demo31", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 94863, "Датчик температуры", -306, 6, "demo31", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 94861, "Окно", -306, 4, "demo31", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 94865, "Дверь", -306, 2, "demo31", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 94552, "Кондиционер", -305, 3, "demo31", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 94550, "Люстра", -305, 1, "demo31", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 94554, "Увлажнитель", -305, 5, "demo31", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 102403, "Датчик температуры", -320, 6, "demo32", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 102401, "Окно", -320, 4, "demo32", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 102405, "Дверь", -320, 2, "demo32", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 108241, "Окно", -328, 4, "demo33", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 120754, "Увлажнитель", -345, 5, "demo35", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 108245, "Дверь", -328, 2, "demo33", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 107912, "Кондиционер", -327, 3, "demo33", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 113902, "Кондиционер", -335, 3, "demo34", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 113900, "Люстра", -335, 1, "demo34", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 122505, "Дверь", -350, 2, "demo35", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 122501, "Окно", -350, 4, "demo35", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 122503, "Датчик температуры", -350, 6, "demo35", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 122150, "Люстра", -349, 1, "demo35", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 122154, "Увлажнитель", -349, 5, "demo35", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 122152, "Кондиционер", -349, 3, "demo35", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 113904, "Увлажнитель", -335, 5, "demo34", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 121803, "Датчик температуры", -348, 6, "demo35", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 121805, "Дверь", -348, 2, "demo35", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 121454, "Увлажнитель", -347, 5, "demo35", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 121452, "Кондиционер", -347, 3, "demo35", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 121450, "Люстра", -347, 1, "demo35", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 121101, "Окно", -346, 4, "demo35", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 121105, "Дверь", -346, 2, "demo35", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 121103, "Датчик температуры", -346, 6, "demo35", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 120752, "Кондиционер", -345, 3, "demo35", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 121801, "Окно", -348, 4, "demo35", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 114241, "Окно", -336, 4, "demo34", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 114245, "Дверь", -336, 2, "demo34", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 114243, "Датчик температуры", -336, 6, "demo34", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 107914, "Увлажнитель", -327, 5, "demo33", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 107581, "Окно", -326, 4, "demo33", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 107583, "Датчик температуры", -326, 6, "demo33", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 107585, "Дверь", -326, 2, "demo33", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 107252, "Кондиционер", -325, 3, "demo33", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 107250, "Люстра", -325, 1, "demo33", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 107254, "Увлажнитель", -325, 5, "demo33", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 115601, "Окно", -340, 4, "demo34", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 115605, "Дверь", -340, 2, "demo34", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 115603, "Датчик температуры", -340, 6, "demo34", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 115264, "Увлажнитель", -339, 5, "demo34", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 115262, "Кондиционер", -339, 3, "demo34", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 115260, "Люстра", -339, 1, "demo34", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 114921, "Окно", -338, 4, "demo34", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 114925, "Дверь", -338, 2, "demo34", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 114923, "Датчик температуры", -338, 6, "demo34", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 114580, "Люстра", -337, 1, "demo34", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 114584, "Увлажнитель", -337, 5, "demo34", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 114582, "Кондиционер", -337, 3, "demo34", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 107910, "Люстра", -327, 1, "demo33", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 44101, "Окно", -210, 4, "demo21", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39002, "Кондиционер", -195, 3, "ws20", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39000, "Люстра", -195, 1, "ws20", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4761, "Окно", -68, 4, "ws7", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4763, "Датчик температуры", -68, 6, "ws7", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4765, "Дверь", -68, 2, "ws7", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4694, "Увлажнитель", -67, 5, "ws7", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4690, "Люстра", -67, 1, "ws7", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4692, "Кондиционер", -67, 3, "ws7", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4623, "Датчик температуры", -66, 6, "ws7", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4625, "Дверь", -66, 2, "ws7", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4832, "Кондиционер", -69, 3, "ws7", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4621, "Окно", -66, 4, "ws7", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4550, "Люстра", -65, 1, "ws7", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4552, "Кондиционер", -65, 3, "ws7", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6403, "Датчик температуры", -80, 6, "ws8", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6401, "Окно", -80, 4, "ws8", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6405, "Дверь", -80, 2, "ws8", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6324, "Увлажнитель", -79, 5, "ws8", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6320, "Люстра", -79, 1, "ws8", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6322, "Кондиционер", -79, 3, "ws8", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4554, "Увлажнитель", -65, 5, "ws7", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4834, "Увлажнитель", -69, 5, "ws7", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4830, "Люстра", -69, 1, "ws7", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4905, "Дверь", -70, 2, "ws7", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3603, "Датчик температуры", -60, 6, "ws6", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3601, "Окно", -60, 4, "ws6", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3540, "Люстра", -59, 1, "ws6", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3542, "Кондиционер", -59, 3, "ws6", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3544, "Увлажнитель", -59, 5, "ws6", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3481, "Окно", -58, 4, "ws6", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3485, "Дверь", -58, 2, "ws6", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3483, "Датчик температуры", -58, 6, "ws6", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3422, "Кондиционер", -57, 3, "ws6", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3424, "Увлажнитель", -57, 5, "ws6", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3420, "Люстра", -57, 1, "ws6", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3361, "Окно", -56, 4, "ws6", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3365, "Дверь", -56, 2, "ws6", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3363, "Датчик температуры", -56, 6, "ws6", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3300, "Люстра", -55, 1, "ws6", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3304, "Увлажнитель", -55, 5, "ws6", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3302, "Кондиционер", -55, 3, "ws6", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4903, "Датчик температуры", -70, 6, "ws7", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 4901, "Окно", -70, 4, "ws7", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6243, "Датчик температуры", -78, 6, "ws8", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 3605, "Дверь", -60, 2, "ws6", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6245, "Дверь", -78, 2, "ws8", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6164, "Увлажнитель", -77, 5, "ws8", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7654, "Увлажнитель", -85, 5, "ws9", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7652, "Кондиционер", -85, 3, "ws9", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7650, "Люстра", -85, 1, "ws9", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 10005, "Дверь", -100, 2, "ws10", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 10001, "Окно", -100, 4, "ws10", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 10003, "Датчик температуры", -100, 6, "ws10", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9904, "Увлажнитель", -99, 5, "ws10", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9902, "Кондиционер", -99, 3, "ws10", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7743, "Датчик температуры", -86, 6, "ws9", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9900, "Люстра", -99, 1, "ws10", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9803, "Датчик температуры", -98, 6, "ws10", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9805, "Дверь", -98, 2, "ws10", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9704, "Увлажнитель", -97, 5, "ws10", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9702, "Кондиционер", -97, 3, "ws10", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9700, "Люстра", -97, 1, "ws10", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9603, "Датчик температуры", -96, 6, "ws10", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9605, "Дверь", -96, 2, "ws10", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9601, "Окно", -96, 4, "ws10", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9801, "Окно", -98, 4, "ws10", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7741, "Окно", -86, 4, "ws9", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7745, "Дверь", -86, 2, "ws9", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7834, "Увлажнитель", -87, 5, "ws9", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6160, "Люстра", -77, 1, "ws8", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6162, "Кондиционер", -77, 3, "ws8", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6085, "Дверь", -76, 2, "ws8", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6081, "Окно", -76, 4, "ws8", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6083, "Датчик температуры", -76, 6, "ws8", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6002, "Кондиционер", -75, 3, "ws8", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6000, "Люстра", -75, 1, "ws8", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6004, "Увлажнитель", -75, 5, "ws8", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 8105, "Дверь", -90, 2, "ws9", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 8101, "Окно", -90, 4, "ws9", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 8103, "Датчик температуры", -90, 6, "ws9", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 8010, "Люстра", -89, 1, "ws9", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 8014, "Увлажнитель", -89, 5, "ws9", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 8012, "Кондиционер", -89, 3, "ws9", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7925, "Дверь", -88, 2, "ws9", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7921, "Окно", -88, 4, "ws9", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7923, "Датчик температуры", -88, 6, "ws9", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7832, "Кондиционер", -87, 3, "ws9", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 7830, "Люстра", -87, 1, "ws9", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 6241, "Окно", -78, 4, "ws8", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9504, "Увлажнитель", -95, 5, "ws10", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2254, "Увлажнитель", -45, 5, "ws5", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2252, "Кондиционер", -45, 3, "ws5", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 363, "Датчик температуры", -18, 6, "ws2", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 365, "Дверь", -18, 2, "ws2", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 361, "Окно", -18, 4, "ws2", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 344, "Увлажнитель", -17, 5, "ws2", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 342, "Кондиционер", -17, 3, "ws2", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 340, "Люстра", -17, 1, "ws2", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 323, "Датчик температуры", -16, 6, "ws2", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 321, "Окно", -16, 4, "ws2", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 380, "Люстра", -19, 1, "ws2", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 325, "Дверь", -16, 2, "ws2", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 302, "Кондиционер", -15, 3, "ws2", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 300, "Люстра", -15, 1, "ws2", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 901, "Окно", -30, 4, "ws3", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 905, "Дверь", -30, 2, "ws3", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 903, "Датчик температуры", -30, 6, "ws3", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 874, "Увлажнитель", -29, 5, "ws3", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 872, "Кондиционер", -29, 3, "ws3", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 870, "Люстра", -29, 1, "ws3", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 304, "Увлажнитель", -15, 5, "ws2", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 382, "Кондиционер", -19, 3, "ws2", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 384, "Увлажнитель", -19, 5, "ws2", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 405, "Дверь", -20, 2, "ws2", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 101, "Окно", -10, 4, "ws1", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 105, "Дверь", -10, 2, "ws1", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 94, "Увлажнитель", -9, 5, "ws1", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 92, "Кондиционер", -9, 3, "ws1", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 90, "Люстра", -9, 1, "ws1", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 85, "Дверь", -8, 2, "ws1", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 81, "Окно", -8, 4, "ws1", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 83, "Датчик температуры", -8, 6, "ws1", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 74, "Увлажнитель", -7, 5, "ws1", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 72, "Кондиционер", -7, 3, "ws1", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 70, "Люстра", -7, 1, "ws1", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 63, "Датчик температуры", -6, 6, "ws1", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 65, "Дверь", -6, 2, "ws1", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 61, "Окно", -6, 4, "ws1", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 54, "Увлажнитель", -5, 5, "ws1", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 50, "Люстра", -5, 1, "ws1", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 52, "Кондиционер", -5, 3, "ws1", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 401, "Окно", -20, 4, "ws2", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 403, "Датчик температуры", -20, 6, "ws2", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 841, "Окно", -28, 4, "ws3", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2250, "Люстра", -45, 1, "ws5", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 845, "Дверь", -28, 2, "ws3", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 810, "Люстра", -27, 1, "ws3", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1402, "Кондиционер", -35, 3, "ws4", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1400, "Люстра", -35, 1, "ws4", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1404, "Увлажнитель", -35, 5, "ws4", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2501, "Окно", -50, 4, "ws5", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2505, "Дверь", -50, 2, "ws5", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2503, "Датчик температуры", -50, 6, "ws5", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2450, "Люстра", -49, 1, "ws5", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2452, "Кондиционер", -49, 3, "ws5", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1441, "Окно", -36, 4, "ws4", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2454, "Увлажнитель", -49, 5, "ws5", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2403, "Датчик температуры", -48, 6, "ws5", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2405, "Дверь", -48, 2, "ws5", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2354, "Увлажнитель", -47, 5, "ws5", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2350, "Люстра", -47, 1, "ws5", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2352, "Кондиционер", -47, 3, "ws5", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2301, "Окно", -46, 4, "ws5", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2303, "Датчик температуры", -46, 6, "ws5", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2305, "Дверь", -46, 2, "ws5", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 2401, "Окно", -48, 4, "ws5", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1443, "Датчик температуры", -36, 6, "ws4", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1445, "Дверь", -36, 2, "ws4", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1482, "Кондиционер", -37, 3, "ws4", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 812, "Кондиционер", -27, 3, "ws3", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 814, "Увлажнитель", -27, 5, "ws3", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 783, "Датчик температуры", -26, 6, "ws3", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 781, "Окно", -26, 4, "ws3", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 785, "Дверь", -26, 2, "ws3", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 750, "Люстра", -25, 1, "ws3", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 754, "Увлажнитель", -25, 5, "ws3", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 752, "Кондиционер", -25, 3, "ws3", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1605, "Дверь", -40, 2, "ws4", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1601, "Окно", -40, 4, "ws4", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1603, "Датчик температуры", -40, 6, "ws4", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1560, "Люстра", -39, 1, "ws4", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1564, "Увлажнитель", -39, 5, "ws4", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1562, "Кондиционер", -39, 3, "ws4", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1525, "Дверь", -38, 2, "ws4", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1521, "Окно", -38, 4, "ws4", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1523, "Датчик температуры", -38, 6, "ws4", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1484, "Увлажнитель", -37, 5, "ws4", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 1480, "Люстра", -37, 1, "ws4", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 843, "Датчик температуры", -28, 6, "ws3", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9502, "Кондиционер", -95, 3, "ws10", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 9500, "Люстра", -95, 1, "ws10", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 12101, "Окно", -110, 4, "ws11", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28563, "Датчик температуры", -168, 6, "ws17", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28565, "Дверь", -168, 2, "ws17", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28394, "Увлажнитель", -167, 5, "ws17", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28392, "Кондиционер", -167, 3, "ws17", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28390, "Люстра", -167, 1, "ws17", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28225, "Дверь", -166, 2, "ws17", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28221, "Окно", -166, 4, "ws17", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28223, "Датчик температуры", -166, 6, "ws17", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28561, "Окно", -168, 4, "ws17", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28054, "Увлажнитель", -165, 5, "ws17", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28052, "Кондиционер", -165, 3, "ws17", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 32401, "Окно", -180, 4, "ws18", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 32403, "Датчик температуры", -180, 6, "ws18", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 32405, "Дверь", -180, 2, "ws18", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 32220, "Люстра", -179, 1, "ws18", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 32224, "Увлажнитель", -179, 5, "ws18", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 32222, "Кондиционер", -179, 3, "ws18", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 32043, "Датчик температуры", -178, 6, "ws18", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28050, "Люстра", -165, 1, "ws17", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28730, "Люстра", -169, 1, "ws17", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28732, "Кондиционер", -169, 3, "ws17", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28734, "Увлажнитель", -169, 5, "ws17", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25605, "Дверь", -160, 2, "ws16", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25444, "Увлажнитель", -159, 5, "ws16", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25440, "Люстра", -159, 1, "ws16", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25442, "Кондиционер", -159, 3, "ws16", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25285, "Дверь", -158, 2, "ws16", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25281, "Окно", -158, 4, "ws16", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25283, "Датчик температуры", -158, 6, "ws16", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25124, "Увлажнитель", -157, 5, "ws16", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25120, "Люстра", -157, 1, "ws16", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25122, "Кондиционер", -157, 3, "ws16", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 24965, "Дверь", -156, 2, "ws16", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 24963, "Датчик температуры", -156, 6, "ws16", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 24961, "Окно", -156, 4, "ws16", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 24804, "Увлажнитель", -155, 5, "ws16", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 24802, "Кондиционер", -155, 3, "ws16", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 24800, "Люстра", -155, 1, "ws16", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28901, "Окно", -170, 4, "ws17", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28905, "Дверь", -170, 2, "ws17", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 28903, "Датчик температуры", -170, 6, "ws17", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 32045, "Дверь", -178, 2, "ws18", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25603, "Датчик температуры", -160, 6, "ws16", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 32041, "Окно", -178, 4, "ws18", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 31862, "Кондиционер", -177, 3, "ws18", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35152, "Кондиционер", -185, 3, "ws19", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35150, "Люстра", -185, 1, "ws19", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 40005, "Дверь", -200, 2, "ws20", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 40001, "Окно", -200, 4, "ws20", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 40003, "Датчик температуры", -200, 6, "ws20", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39800, "Люстра", -199, 1, "ws20", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39804, "Увлажнитель", -199, 5, "ws20", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39802, "Кондиционер", -199, 3, "ws20", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35154, "Увлажнитель", -185, 5, "ws19", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39601, "Окно", -198, 4, "ws20", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39603, "Датчик температуры", -198, 6, "ws20", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39404, "Увлажнитель", -197, 5, "ws20", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39402, "Кондиционер", -197, 3, "ws20", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39400, "Люстра", -197, 1, "ws20", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39201, "Окно", -196, 4, "ws20", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39203, "Датчик температуры", -196, 6, "ws20", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39205, "Дверь", -196, 2, "ws20", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39004, "Увлажнитель", -195, 5, "ws20", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 39605, "Дверь", -198, 2, "ws20", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35343, "Датчик температуры", -186, 6, "ws19", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35341, "Окно", -186, 4, "ws19", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35345, "Дверь", -186, 2, "ws19", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 31864, "Увлажнитель", -177, 5, "ws18", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 31685, "Дверь", -176, 2, "ws18", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 31683, "Датчик температуры", -176, 6, "ws18", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 31681, "Окно", -176, 4, "ws18", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 31500, "Люстра", -175, 1, "ws18", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 31504, "Увлажнитель", -175, 5, "ws18", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 31502, "Кондиционер", -175, 3, "ws18", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 36103, "Датчик температуры", -190, 6, "ws19", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 36105, "Дверь", -190, 2, "ws19", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 36101, "Окно", -190, 4, "ws19", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35912, "Кондиционер", -189, 3, "ws19", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35914, "Увлажнитель", -189, 5, "ws19", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35910, "Люстра", -189, 1, "ws19", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35721, "Окно", -188, 4, "ws19", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35723, "Датчик температуры", -188, 6, "ws19", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35725, "Дверь", -188, 2, "ws19", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35534, "Увлажнитель", -187, 5, "ws19", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35530, "Люстра", -187, 1, "ws19", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 35532, "Кондиционер", -187, 3, "ws19", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 31860, "Люстра", -177, 1, "ws18", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 25601, "Окно", -160, 4, "ws16", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 21752, "Кондиционер", -145, 3, "ws15", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 21750, "Люстра", -145, 1, "ws15", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14165, "Дверь", -118, 2, "ws12", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14163, "Датчик температуры", -118, 6, "ws12", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14161, "Окно", -118, 4, "ws12", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14042, "Кондиционер", -117, 3, "ws12", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14040, "Люстра", -117, 1, "ws12", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14044, "Увлажнитель", -117, 5, "ws12", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 13923, "Датчик температуры", -116, 6, "ws12", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 13925, "Дверь", -116, 2, "ws12", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14284, "Увлажнитель", -119, 5, "ws12", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 13921, "Окно", -116, 4, "ws12", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 13800, "Люстра", -115, 1, "ws12", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 13802, "Кондиционер", -115, 3, "ws12", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16901, "Окно", -130, 4, "ws13", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16905, "Дверь", -130, 2, "ws13", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16903, "Датчик температуры", -130, 6, "ws13", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16770, "Люстра", -129, 1, "ws13", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16774, "Увлажнитель", -129, 5, "ws13", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16772, "Кондиционер", -129, 3, "ws13", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 13804, "Увлажнитель", -115, 5, "ws12", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14282, "Кондиционер", -119, 3, "ws12", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14280, "Люстра", -119, 1, "ws12", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14401, "Окно", -120, 4, "ws12", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 12103, "Датчик температуры", -110, 6, "ws11", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 12105, "Дверь", -110, 2, "ws11", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11990, "Люстра", -109, 1, "ws11", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11992, "Кондиционер", -109, 3, "ws11", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11994, "Увлажнитель", -109, 5, "ws11", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11883, "Датчик температуры", -108, 6, "ws11", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11881, "Окно", -108, 4, "ws11", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11885, "Дверь", -108, 2, "ws11", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11774, "Увлажнитель", -107, 5, "ws11", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11772, "Кондиционер", -107, 3, "ws11", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11770, "Люстра", -107, 1, "ws11", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11665, "Дверь", -106, 2, "ws11", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11663, "Датчик температуры", -106, 6, "ws11", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11661, "Окно", -106, 4, "ws11", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11552, "Кондиционер", -105, 3, "ws11", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11554, "Увлажнитель", -105, 5, "ws11", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 11550, "Люстра", -105, 1, "ws11", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14403, "Датчик температуры", -120, 6, "ws12", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 14405, "Дверь", -120, 2, "ws12", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16641, "Окно", -128, 4, "ws13", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16645, "Дверь", -128, 2, "ws13", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16643, "Датчик температуры", -128, 6, "ws13", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16512, "Кондиционер", -127, 3, "ws13", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 18904, "Увлажнитель", -135, 5, "ws14", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 18900, "Люстра", -135, 1, "ws14", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 18902, "Кондиционер", -135, 3, "ws14", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22505, "Дверь", -150, 2, "ws15", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22503, "Датчик температуры", -150, 6, "ws15", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22501, "Окно", -150, 4, "ws15", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22352, "Кондиционер", -149, 3, "ws15", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22354, "Увлажнитель", -149, 5, "ws15", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22350, "Люстра", -149, 1, "ws15", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22201, "Окно", -148, 4, "ws15", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22203, "Датчик температуры", -148, 6, "ws15", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22205, "Дверь", -148, 2, "ws15", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22050, "Люстра", -147, 1, "ws15", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22054, "Увлажнитель", -147, 5, "ws15", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 22052, "Кондиционер", -147, 3, "ws15", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 21903, "Датчик температуры", -146, 6, "ws15", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 21905, "Дверь", -146, 2, "ws15", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 21901, "Окно", -146, 4, "ws15", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 21754, "Увлажнитель", -145, 5, "ws15", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19043, "Датчик температуры", -136, 6, "ws14", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 158004, "Увлажнитель", -395, 5, "demo40", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19045, "Дверь", -136, 2, "ws14", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19184, "Увлажнитель", -137, 5, "ws14", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16510, "Люстра", -127, 1, "ws13", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16514, "Увлажнитель", -127, 5, "ws13", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16383, "Датчик температуры", -126, 6, "ws13", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16381, "Окно", -126, 4, "ws13", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16385, "Дверь", -126, 2, "ws13", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16254, "Увлажнитель", -125, 5, "ws13", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16252, "Кондиционер", -125, 3, "ws13", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 16250, "Люстра", -125, 1, "ws13", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19601, "Окно", -140, 4, "ws14", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19603, "Датчик температуры", -140, 6, "ws14", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19605, "Дверь", -140, 2, "ws14", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19464, "Увлажнитель", -139, 5, "ws14", "4" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19460, "Люстра", -139, 1, "ws14", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19462, "Кондиционер", -139, 3, "ws14", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19325, "Дверь", -138, 2, "ws14", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19321, "Окно", -138, 4, "ws14", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19323, "Датчик температуры", -138, 6, "ws14", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19182, "Кондиционер", -137, 3, "ws14", "+20" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19180, "Люстра", -137, 1, "ws14", "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 19041, "Окно", -136, 4, "ws14", "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "Type", "UserId", "Value" },
                values: new object[] { 158000, "Люстра", -395, 1, "demo40", "off" });

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
                name: "IX_Macros_UserId",
                table: "Macros",
                column: "UserId");

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
