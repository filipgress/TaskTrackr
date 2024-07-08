using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskTrackr.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.ProjectsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ProjectUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Project_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Task_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "27b2b0ee-f424-4dc3-9631-716b20cfecb7", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(7998), null, "filipgress@gmail.com", false, false, null, null, null, null, null, false, "1aa89db9-87cf-4458-84e0-55a70228b4e6", false, "Filip Gres" },
                    { "2", 0, "e436e4fb-2a56-4ed1-b4af-c4ada078fd9f", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8289), null, "mareklesny@gmail.com", false, false, null, null, null, null, null, false, "497fbe81-9bdf-4c4b-a6c7-042f6bf842f2", false, "Marek Lesny" },
                    { "3", 0, "4aa6b4bd-3db0-4242-85f2-2ce468ca10ea", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8347), null, "gregorhudak@gmail.com", false, false, null, null, null, null, null, false, "93efc396-aa51-4530-8e6a-7ddd4c24aec7", false, "Gregor Hudak" },
                    { "4", 0, "cbee1c69-9b6a-485e-b107-0e98f4042527", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8404), null, "martindvorsky@gmail.com", false, false, null, null, null, null, null, false, "43f625ab-1c7a-4e87-bc5f-80074a2c4483", false, "Martin Dvorsky" },
                    { "5", 0, "53e4df39-4415-4130-8a6a-1896589036e2", new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8458), null, "sebastianbach@gmail.com", false, false, null, null, null, null, null, false, "c22dee3c-da60-43c8-8006-d69ee28c642d", false, "Sebastian Bach" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8842), null, "An eco-friendly transportation project promoting the use of bicycles in urban areas. UrbanCycle includes the development of bike-sharing systems, dedicated cycling lanes, and community events to encourage a shift towards sustainable transportation.", "UrbanCycle" },
                    { 2, new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8938), null, "A telehealth project that aims to provide remote healthcare services to patients in remote and underserved areas. HealthConnect uses advanced telecommunication technologies to connect patients with healthcare professionals for consultations, diagnoses, and follow-ups.", "Health Connect" },
                    { 3, new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8971), null, "A project dedicated to the conservation of endangered bird species. BioNest focuses on habitat restoration, breeding programs, and community education to protect and preserve avian biodiversity.", "BioNest" },
                    { 4, new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(8998), null, "An agricultural innovation project that leverages IoT and AI to optimize farming practices. SmartFarm aims to increase crop yields, reduce waste, and promote sustainable farming through smart sensors and data analytics.", "Smart Farm" },
                    { 5, new DateTime(2024, 6, 5, 20, 55, 8, 453, DateTimeKind.Local).AddTicks(9063), null, "An initiative to develop a sustainable energy solution using advanced solar technology. The project aims to create efficient solar panels that can be integrated into urban infrastructure to reduce reliance on fossil fuels.", "Phoenix" }
                });

            migrationBuilder.InsertData(
                table: "ProjectUser",
                columns: new[] { "ProjectsId", "UsersId" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 1, "4" },
                    { 2, "1" },
                    { 2, "4" },
                    { 2, "5" },
                    { 3, "2" },
                    { 3, "5" },
                    { 4, "2" },
                    { 5, "2" },
                    { 5, "3" }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "CompletedAt", "CreatedAt", "DeletedAt", "Description", "Difficulty", "DueDate", "Name", "Priority", "ProjectId", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 5, 31, 9, 50, 52, 796, DateTimeKind.Local).AddTicks(4664), null, "Create a prototype for the new solar panel design incorporating the latest photovoltaic technology to enhance efficiency.", 8, new DateTime(2024, 6, 28, 8, 42, 52, 797, DateTimeKind.Local).AddTicks(96), "Design Prototype Solar Panel", 1, 5, "1" },
                    { 2, null, new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2512), null, "Test the prototype solar panels under various environmental conditions to measure their efficiency and durability.", 7, new DateTime(2024, 6, 1, 6, 54, 52, 797, DateTimeKind.Local).AddTicks(2540), "Conduct Efficiency Testing", 1, 5, "1" },
                    { 3, null, new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2571), null, "Create a detailed guide for the installation of the new solar panels, including safety protocols and optimization tips.", 5, new DateTime(2024, 6, 15, 20, 22, 52, 797, DateTimeKind.Local).AddTicks(2576), "Develop Installation Guidelines", 2, 5, "1" },
                    { 4, null, new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2590), null, "Enhance the energy storage system to improve the efficiency of storing and distributing the solar energy collected.", 7, new DateTime(2024, 6, 23, 7, 52, 52, 797, DateTimeKind.Local).AddTicks(2593), "Optimize Energy Storage System", 1, 5, "1" },
                    { 5, null, new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2604), null, "Develop and implement a system for integrating the solar panels with existing smart grid technology to ensure efficient energy distribution.", 9, new DateTime(2024, 6, 20, 3, 59, 52, 797, DateTimeKind.Local).AddTicks(2608), "Implement Smart Grid Integration", 2, 5, "3" },
                    { 6, null, new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2772), null, "Work with regulatory bodies to obtain all necessary approvals and certifications for the new solar panel technology.", 3, new DateTime(2024, 6, 1, 15, 10, 52, 797, DateTimeKind.Local).AddTicks(2777), "Secure Regulatory Approvals", 0, 5, "3" },
                    { 7, null, new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2806), null, "Develop a comprehensive marketing strategy to promote the new solar panels to residential and commercial customers.", 4, new DateTime(2024, 6, 30, 1, 45, 52, 797, DateTimeKind.Local).AddTicks(2810), "Create Marketing Strategy", 3, 5, "2" },
                    { 8, null, new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2820), null, "Design and set up a manufacturing process for mass production of the new solar panels, ensuring quality control and cost efficiency.", 10, new DateTime(2024, 6, 9, 6, 36, 52, 797, DateTimeKind.Local).AddTicks(2831), "Establish Manufacturing Process", 0, 5, "1" },
                    { 9, null, new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2842), null, "Develop and conduct a training program for technicians who will be installing the new solar panels, covering all technical and safety aspects.", 6, new DateTime(2024, 6, 16, 6, 15, 52, 797, DateTimeKind.Local).AddTicks(2846), "Train Installation Technicians", 2, 5, "2" },
                    { 10, null, new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2858), null, "Set up a monitoring system to assess the environmental impact of the new solar panels, focusing on reducing the carbon footprint.", 4, new DateTime(2024, 6, 13, 23, 15, 52, 797, DateTimeKind.Local).AddTicks(2861), "Monitor Environmental Impact", 3, 5, "2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_UsersId",
                table: "ProjectUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_ProjectId",
                table: "Task",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_UserId",
                table: "Task",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
