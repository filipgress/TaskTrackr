using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskTrackr.Migrations
{
    /// <inheritdoc />
    public partial class UserPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82ca616b-d94f-4f98-9257-b9928a445413", new DateTime(2024, 6, 6, 2, 43, 48, 849, DateTimeKind.Local).AddTicks(2553), "AQAAAAIAAYagAAAAEHBE++IHjCOxjdENs2TqIubliEPU9tvYpZSHHDpvaupMyX7BOJuZlbouKNG3VoDRmw==", "e7949ca4-8fc5-4497-8ed9-0e8268955caf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23f62f34-2bd2-4998-873a-1fb065668860", new DateTime(2024, 6, 6, 2, 43, 48, 849, DateTimeKind.Local).AddTicks(3054), "AQAAAAIAAYagAAAAENd9AzTpE4TFeO/Tdn6ENiyaYG2YVSXp2AzYsskJjhMmV0+VYKW9ZizxdvmxzK9GWw==", "3347a7ac-f029-427a-8954-07592a3fbdac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46f265dc-219e-4228-9ef5-1a21401efa81", new DateTime(2024, 6, 6, 2, 43, 48, 849, DateTimeKind.Local).AddTicks(3142), "AQAAAAIAAYagAAAAEERHQGD24w9S4eaJrDqmSNmtuUVCE2nHiJqvl7KTMYf2LtoIyFNLQNRIwrRvyQPlbQ==", "196ca891-49c7-4067-8633-40f3d9ae3544" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a536e1b7-b33f-4e2d-8267-1849b5987337", new DateTime(2024, 6, 6, 2, 43, 48, 849, DateTimeKind.Local).AddTicks(3239), "AQAAAAIAAYagAAAAEHRzZzspfbO5GVpba3LU/KL26AYmM7pn3GJCnTWlZ0yqd2SqiAAHgZwAe2Fa1wLIng==", "5a38a31c-2ba9-48d2-9d4f-cb742c5fb379" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16a94a0d-cbcf-407b-9367-427d29221ee3", new DateTime(2024, 6, 6, 2, 43, 48, 849, DateTimeKind.Local).AddTicks(3331), "AQAAAAIAAYagAAAAELgd3cq8aE3xUmoo6zw+pfhOHX546LKgxlQmimVwsaK7cUy7QPddL33nWhdXLW2oUg==", "955a819c-ef6c-44d5-ae0d-53299b206711" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 43, 49, 444, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 43, 49, 444, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 43, 49, 444, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 43, 49, 444, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 2, 43, 49, 444, DateTimeKind.Local).AddTicks(3071));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccc56b4a-2910-4f1f-84a8-d68431eb0e71", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5079), null, "898255e4-f0fc-49c2-bfa1-9355367ab115" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "215eea96-651e-4ef0-ac17-00aca674ca56", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5460), null, "932dad68-c328-4b59-bbad-12828b6013f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50e41ba2-668e-431b-a6d0-e4ccf2967462", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5573), null, "e064d3dd-260d-4cf8-8ab4-bf1ec5fa2a59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "129cb8f6-f847-4257-908c-19f946219c10", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5673), null, "ac672c22-aea1-4a51-b6fa-645d702bd20c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e0a6f50-379f-48a8-9e76-22eab29999e5", new DateTime(2024, 6, 6, 2, 37, 35, 847, DateTimeKind.Local).AddTicks(5766), null, "ad9decdc-7579-42df-9453-597e05ec4322" });

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
    }
}
