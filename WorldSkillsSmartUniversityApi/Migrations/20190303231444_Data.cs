using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldSkillsSmartUniversityApi.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeviceType",
                columns: new[] { "Id", "Name" },
                values: new object[] { -1, "Переключатели" });

            migrationBuilder.InsertData(
                table: "DeviceType",
                columns: new[] { "Id", "Name" },
                values: new object[] { -2, "Окна" });

            migrationBuilder.InsertData(
                table: "DeviceType",
                columns: new[] { "Id", "Name" },
                values: new object[] { -3, "Температурные" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name", "Photo" },
                values: new object[] { -1, "A914", "sharaga.png" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { -1, "pitux", "Vitya" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "TypeId", "Value" },
                values: new object[] { -1, "Люстра", -1, -1, "off" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "TypeId", "Value" },
                values: new object[] { -2, "Окно", -1, -2, "closed" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "RoomId", "TypeId", "Value" },
                values: new object[] { -3, "Кондиционер", -1, -3, "+20" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "DeviceType",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "DeviceType",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "DeviceType",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
