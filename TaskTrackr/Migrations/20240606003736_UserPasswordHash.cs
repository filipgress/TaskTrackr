using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskTrackr.Migrations
{
    /// <inheritdoc />
    public partial class UserPasswordHash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "ccc56b4a-2910-4f1f-84a8-d68431eb0e71", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5079), "898255e4-f0fc-49c2-bfa1-9355367ab115" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "215eea96-651e-4ef0-ac17-00aca674ca56", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5460), "932dad68-c328-4b59-bbad-12828b6013f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "50e41ba2-668e-431b-a6d0-e4ccf2967462", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5573), "e064d3dd-260d-4cf8-8ab4-bf1ec5fa2a59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "129cb8f6-f847-4257-908c-19f946219c10", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5673), "ac672c22-aea1-4a51-b6fa-645d702bd20c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "6e0a6f50-379f-48a8-9e76-22eab29999e5", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5766), "ad9decdc-7579-42df-9453-597e05ec4322" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(6977));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "4dfd1703-b6aa-4483-9800-7dc58f10a9f9", new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1148), "148daddf-66b5-4d99-94c3-2744394733f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "0142f1f8-439e-4a95-8732-409ec14c3059", new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1541), "264fc619-5825-40d7-b43a-80dd8750abf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "761aaed3-2bbe-4f75-93cd-654d19f1ba01", new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1652), "b72d3320-5b0d-4ae9-b11a-595d08e03fbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "a5c4ab46-990d-404f-aa15-26fdd478d6c3", new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1749), "bc5b4a23-8d48-4ee4-b80b-2d4371b01da2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "711d0104-9971-4e22-9ae3-1ff0aec9cf99", new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1846), "cb2b803e-1b9b-480f-9d34-b10e3d8fb77e" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(3138));
        }
    }
}
