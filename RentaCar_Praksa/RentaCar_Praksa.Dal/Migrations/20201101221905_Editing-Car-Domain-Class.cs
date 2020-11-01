using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentaCar_Praksa.Dal.Migrations
{
    public partial class EditingCarDomainClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarDetails",
                table: "Cars",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 1, 22, 19, 3, 860, DateTimeKind.Utc).AddTicks(2977), new DateTime(2020, 11, 1, 22, 19, 3, 859, DateTimeKind.Utc).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 1, 22, 19, 3, 860, DateTimeKind.Utc).AddTicks(3182), new DateTime(2020, 11, 1, 22, 19, 3, 860, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 856, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 856, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 856, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 814, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 814, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 814, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 850, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 850, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 850, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 850, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 23, 19, 3, 829, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 23, 19, 3, 834, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 23, 19, 3, 837, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 23, 19, 3, 837, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 826, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 22, 19, 3, 826, DateTimeKind.Utc).AddTicks(9541));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarDetails",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(8239), new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(8365), new DateTime(2020, 11, 1, 0, 10, 41, 677, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 675, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 675, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 675, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 649, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 649, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 649, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 672, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 1, 10, 41, 657, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 1, 10, 41, 661, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 1, 10, 41, 663, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 1, 10, 41, 663, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 656, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 1, 0, 10, 41, 656, DateTimeKind.Utc).AddTicks(6064));
        }
    }
}
