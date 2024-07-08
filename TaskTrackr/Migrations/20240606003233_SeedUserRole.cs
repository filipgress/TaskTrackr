using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskTrackr.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3061c732-3605-4f74-bffd-34e47a3ab9bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66d9ac5c-fee0-4388-a1ba-e8579625822f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "2", "3" },
                    { "2", "4" },
                    { "2", "5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

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
    }
}
