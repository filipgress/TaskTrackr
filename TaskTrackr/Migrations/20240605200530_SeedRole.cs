using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskTrackr.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3061c732-3605-4f74-bffd-34e47a3ab9bf", null, "User", "USER" },
                    { "66d9ac5c-fee0-4388-a1ba-e8579625822f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "c7243519-8cd4-47ca-997f-39cf27e15e01", new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(7242), "b03a4e96-cedb-455f-8cef-7ce1a72c5791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "5319a5ea-72ec-4b8e-99d9-15cee4ce902e", new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(7562), "4b023bc7-7455-4b1a-afd0-e89eb2a7c9ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "470c7fa7-e9de-4ba0-ad31-4bb96a7e7590", new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(7619), "e4c2d3e9-059a-4f3d-9f81-d1e9c69db986" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "5c5fbc19-2c21-49ff-b80f-5d180521adee", new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(7671), "18b8a1c5-f2fb-415c-a102-3086845737c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "95cd36a5-9fa2-4a3e-bd50-b86fa921ec75", new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(7723), "ec5e627b-dce5-4a24-82ab-9129082d6487" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 22, 5, 30, 517, DateTimeKind.Local).AddTicks(8343));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3061c732-3605-4f74-bffd-34e47a3ab9bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66d9ac5c-fee0-4388-a1ba-e8579625822f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "27b2b0ee-f424-4dc3-9631-716b20cfecb7", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(7998), "1aa89db9-87cf-4458-84e0-55a70228b4e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "e436e4fb-2a56-4ed1-b4af-c4ada078fd9f", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8289), "497fbe81-9bdf-4c4b-a6c7-042f6bf842f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "4aa6b4bd-3db0-4242-85f2-2ce468ca10ea", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8347), "93efc396-aa51-4530-8e6a-7ddd4c24aec7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "cbee1c69-9b6a-485e-b107-0e98f4042527", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8404), "43f625ab-1c7a-4e87-bc5f-80074a2c4483" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "SecurityStamp" },
                values: new object[] { "53e4df39-4415-4130-8a6a-1896589036e2", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8458), "c22dee3c-da60-43c8-8006-d69ee28c642d" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(9063));
        }
    }
}
