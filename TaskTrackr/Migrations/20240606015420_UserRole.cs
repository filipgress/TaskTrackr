using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskTrackr.Migrations
{
    /// <inheritdoc />
    public partial class UserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52c815d9-8bfb-4c55-b6dd-097e2b5f6a1a", new DateTime(2024, 6, 6, 3, 54, 19, 964, DateTimeKind.Local).AddTicks(2695), "AQAAAAIAAYagAAAAEBZdiynE4N/V3wKm5wVZH8yG4Ad0/7OP50JzdN/hg5lQqMaOLUb5KBHKVTrzUCSciw==", "16621308-1b6a-4f6d-8128-9a026f1a8a06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f541e0f7-641a-4ceb-a18c-7beb0248c5cb", new DateTime(2024, 6, 6, 3, 54, 19, 964, DateTimeKind.Local).AddTicks(3065), "AQAAAAIAAYagAAAAEKUzxHTRHYpicR94PBxbG3pekzQQD5a/S/vP07bN9crj8N1ftZYpu36z8W9er0EFQw==", "77611ccc-81bf-424f-a45e-49bfe816ae2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8eb1ebd-0fe6-4156-968a-62f4e4b9ff6a", new DateTime(2024, 6, 6, 3, 54, 19, 964, DateTimeKind.Local).AddTicks(3128), "AQAAAAIAAYagAAAAEJ90u5siJrEb2ZTm2UEEKeU0I6MXSTFpZ2dFG6my4GeGRpsq7/HlOqhP4eY9EXzKiQ==", "c03d6956-94ff-493d-bd60-7797891426cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1827dda1-72ac-4028-86db-df34bbbca8ae", new DateTime(2024, 6, 6, 3, 54, 19, 964, DateTimeKind.Local).AddTicks(3181), "AQAAAAIAAYagAAAAEP0huJMIeqMooZYJVJsNRxAtdSCOUSuy4e7eX+DbA/PeHgXxqPEtvfI46o29h8c7YA==", "d1c7452b-db9b-4910-8d04-4fa6c114eb5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60571e28-b611-4de7-96d1-c36fe5ce4f5a", new DateTime(2024, 6, 6, 3, 54, 19, 964, DateTimeKind.Local).AddTicks(3251), "AQAAAAIAAYagAAAAEKJtFp0sH0QMSAH9M20UkgrUbisnd674ov7MASvorBgtrlNZBL2VDjk3ehvroq3OHQ==", "07404520-ac55-4de9-96c4-778d27eafb7e" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 3, 54, 20, 448, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 3, 54, 20, 448, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 3, 54, 20, 448, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 3, 54, 20, 448, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 3, 54, 20, 448, DateTimeKind.Local).AddTicks(4093));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
