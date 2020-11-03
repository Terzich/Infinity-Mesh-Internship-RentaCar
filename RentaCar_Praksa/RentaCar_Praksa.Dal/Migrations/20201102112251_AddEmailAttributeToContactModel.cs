using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentaCar_Praksa.Dal.Migrations
{
    public partial class AddEmailAttributeToContactModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contacts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 2, 11, 22, 50, 839, DateTimeKind.Utc).AddTicks(2826), new DateTime(2020, 11, 2, 11, 22, 50, 839, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 2, 11, 22, 50, 839, DateTimeKind.Utc).AddTicks(2924), new DateTime(2020, 11, 2, 11, 22, 50, 839, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 837, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 837, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 837, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 818, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 818, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 818, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 834, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 834, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 834, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 834, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 12, 22, 50, 824, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 12, 22, 50, 826, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 12, 22, 50, 828, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 12, 22, 50, 828, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 823, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 22, 50, 823, DateTimeKind.Utc).AddTicks(8133));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 2, 11, 19, 4, 944, DateTimeKind.Utc).AddTicks(7397), new DateTime(2020, 11, 2, 11, 19, 4, 944, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "BookedCars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "From" },
                values: new object[] { new DateTime(2020, 11, 2, 11, 19, 4, 944, DateTimeKind.Utc).AddTicks(7486), new DateTime(2020, 11, 2, 11, 19, 4, 944, DateTimeKind.Utc).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 943, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 943, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 943, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 923, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 923, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 923, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 940, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 940, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 940, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 940, DateTimeKind.Utc).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 12, 19, 4, 930, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 12, 19, 4, 932, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 12, 19, 4, 933, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 12, 19, 4, 933, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 929, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 2, 11, 19, 4, 929, DateTimeKind.Utc).AddTicks(3507));
        }
    }
}
