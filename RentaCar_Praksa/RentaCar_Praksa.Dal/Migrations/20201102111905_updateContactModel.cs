using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentaCar_Praksa.Dal.Migrations
{
    public partial class updateContactModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Question",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Response",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Contacts",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Contacts",
                nullable: true);

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
                columns: new[] { "CreatedAt", "Message" },
                values: new object[] { new DateTime(2020, 11, 2, 12, 19, 4, 930, DateTimeKind.Local).AddTicks(3030), "Koliko dugo mogu da rentam vozilo?" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Message" },
                values: new object[] { new DateTime(2020, 11, 2, 12, 19, 4, 932, DateTimeKind.Local).AddTicks(3247), "Da li su vozila odrzavana redovno?" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question",
                table: "Contacts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "Contacts",
                type: "nvarchar(max)",
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
                columns: new[] { "CreatedAt", "Question" },
                values: new object[] { new DateTime(2020, 11, 1, 23, 19, 3, 829, DateTimeKind.Local).AddTicks(8458), "Koliko dugo mogu da rentam vozilo?" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Question" },
                values: new object[] { new DateTime(2020, 11, 1, 23, 19, 3, 834, DateTimeKind.Local).AddTicks(5397), "Da li su vozila odrzavana redovno?" });

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
    }
}
