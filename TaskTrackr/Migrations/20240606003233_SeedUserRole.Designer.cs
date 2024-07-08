﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskTrackr.Data;

#nullable disable

namespace TaskTrackr.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240606003233_SeedUserRole")]
    partial class SeedUserRole
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "4",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "5",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.Property<int>("ProjectsId")
                        .HasColumnType("int");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProjectsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ProjectUser");

                    b.HasData(
                        new
                        {
                            ProjectsId = 1,
                            UsersId = "1"
                        },
                        new
                        {
                            ProjectsId = 2,
                            UsersId = "1"
                        },
                        new
                        {
                            ProjectsId = 3,
                            UsersId = "2"
                        },
                        new
                        {
                            ProjectsId = 4,
                            UsersId = "2"
                        },
                        new
                        {
                            ProjectsId = 5,
                            UsersId = "2"
                        },
                        new
                        {
                            ProjectsId = 5,
                            UsersId = "3"
                        },
                        new
                        {
                            ProjectsId = 1,
                            UsersId = "4"
                        },
                        new
                        {
                            ProjectsId = 2,
                            UsersId = "4"
                        },
                        new
                        {
                            ProjectsId = 2,
                            UsersId = "5"
                        },
                        new
                        {
                            ProjectsId = 3,
                            UsersId = "5"
                        });
                });

            modelBuilder.Entity("TaskTrackr.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(2577),
                            Description = "An eco-friendly transportation project promoting the use of bicycles in urban areas. UrbanCycle includes the development of bike-sharing systems, dedicated cycling lanes, and community events to encourage a shift towards sustainable transportation.",
                            Name = "UrbanCycle"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(2719),
                            Description = "A telehealth project that aims to provide remote healthcare services to patients in remote and underserved areas. HealthConnect uses advanced telecommunication technologies to connect patients with healthcare professionals for consultations, diagnoses, and follow-ups.",
                            Name = "Health Connect"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(2777),
                            Description = "A project dedicated to the conservation of endangered bird species. BioNest focuses on habitat restoration, breeding programs, and community education to protect and preserve avian biodiversity.",
                            Name = "BioNest"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(2831),
                            Description = "An agricultural innovation project that leverages IoT and AI to optimize farming practices. SmartFarm aims to increase crop yields, reduce waste, and promote sustainable farming through smart sensors and data analytics.",
                            Name = "Smart Farm"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(3138),
                            Description = "An initiative to develop a sustainable energy solution using advanced solar technology. The project aims to create efficient solar panels that can be integrated into urban infrastructure to reduce reliance on fossil fuels.",
                            Name = "Phoenix"
                        });
                });

            modelBuilder.Entity("TaskTrackr.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Task");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 796, DateTimeKind.Local).AddTicks(4664),
                            Description = "Create a prototype for the new solar panel design incorporating the latest photovoltaic technology to enhance efficiency.",
                            Difficulty = 8,
                            DueDate = new DateTime(2024, 6, 28, 8, 42, 52, 797, DateTimeKind.Local).AddTicks(96),
                            Name = "Design Prototype Solar Panel",
                            Priority = 1,
                            ProjectId = 5,
                            UserId = "1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2512),
                            Description = "Test the prototype solar panels under various environmental conditions to measure their efficiency and durability.",
                            Difficulty = 7,
                            DueDate = new DateTime(2024, 6, 1, 6, 54, 52, 797, DateTimeKind.Local).AddTicks(2540),
                            Name = "Conduct Efficiency Testing",
                            Priority = 1,
                            ProjectId = 5,
                            UserId = "1"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2571),
                            Description = "Create a detailed guide for the installation of the new solar panels, including safety protocols and optimization tips.",
                            Difficulty = 5,
                            DueDate = new DateTime(2024, 6, 15, 20, 22, 52, 797, DateTimeKind.Local).AddTicks(2576),
                            Name = "Develop Installation Guidelines",
                            Priority = 2,
                            ProjectId = 5,
                            UserId = "1"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2590),
                            Description = "Enhance the energy storage system to improve the efficiency of storing and distributing the solar energy collected.",
                            Difficulty = 7,
                            DueDate = new DateTime(2024, 6, 23, 7, 52, 52, 797, DateTimeKind.Local).AddTicks(2593),
                            Name = "Optimize Energy Storage System",
                            Priority = 1,
                            ProjectId = 5,
                            UserId = "1"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2604),
                            Description = "Develop and implement a system for integrating the solar panels with existing smart grid technology to ensure efficient energy distribution.",
                            Difficulty = 9,
                            DueDate = new DateTime(2024, 6, 20, 3, 59, 52, 797, DateTimeKind.Local).AddTicks(2608),
                            Name = "Implement Smart Grid Integration",
                            Priority = 2,
                            ProjectId = 5,
                            UserId = "3"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2772),
                            Description = "Work with regulatory bodies to obtain all necessary approvals and certifications for the new solar panel technology.",
                            Difficulty = 3,
                            DueDate = new DateTime(2024, 6, 1, 15, 10, 52, 797, DateTimeKind.Local).AddTicks(2777),
                            Name = "Secure Regulatory Approvals",
                            Priority = 0,
                            ProjectId = 5,
                            UserId = "3"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2806),
                            Description = "Develop a comprehensive marketing strategy to promote the new solar panels to residential and commercial customers.",
                            Difficulty = 4,
                            DueDate = new DateTime(2024, 6, 30, 1, 45, 52, 797, DateTimeKind.Local).AddTicks(2810),
                            Name = "Create Marketing Strategy",
                            Priority = 3,
                            ProjectId = 5,
                            UserId = "2"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2820),
                            Description = "Design and set up a manufacturing process for mass production of the new solar panels, ensuring quality control and cost efficiency.",
                            Difficulty = 10,
                            DueDate = new DateTime(2024, 6, 9, 6, 36, 52, 797, DateTimeKind.Local).AddTicks(2831),
                            Name = "Establish Manufacturing Process",
                            Priority = 0,
                            ProjectId = 5,
                            UserId = "1"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2842),
                            Description = "Develop and conduct a training program for technicians who will be installing the new solar panels, covering all technical and safety aspects.",
                            Difficulty = 6,
                            DueDate = new DateTime(2024, 6, 16, 6, 15, 52, 797, DateTimeKind.Local).AddTicks(2846),
                            Name = "Train Installation Technicians",
                            Priority = 2,
                            ProjectId = 5,
                            UserId = "2"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 5, 31, 9, 50, 52, 797, DateTimeKind.Local).AddTicks(2858),
                            Description = "Set up a monitoring system to assess the environmental impact of the new solar panels, focusing on reducing the carbon footprint.",
                            Difficulty = 4,
                            DueDate = new DateTime(2024, 6, 13, 23, 15, 52, 797, DateTimeKind.Local).AddTicks(2861),
                            Name = "Monitor Environmental Impact",
                            Priority = 3,
                            ProjectId = 5,
                            UserId = "2"
                        });
                });

            modelBuilder.Entity("TaskTrackr.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4dfd1703-b6aa-4483-9800-7dc58f10a9f9",
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1148),
                            Email = "filipgress@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "148daddf-66b5-4d99-94c3-2744394733f7",
                            TwoFactorEnabled = false,
                            UserName = "Filip Gres"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0142f1f8-439e-4a95-8732-409ec14c3059",
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1541),
                            Email = "mareklesny@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "264fc619-5825-40d7-b43a-80dd8750abf6",
                            TwoFactorEnabled = false,
                            UserName = "Marek Lesny"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "761aaed3-2bbe-4f75-93cd-654d19f1ba01",
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1652),
                            Email = "gregorhudak@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b72d3320-5b0d-4ae9-b11a-595d08e03fbe",
                            TwoFactorEnabled = false,
                            UserName = "Gregor Hudak"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a5c4ab46-990d-404f-aa15-26fdd478d6c3",
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1749),
                            Email = "martindvorsky@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bc5b4a23-8d48-4ee4-b80b-2d4371b01da2",
                            TwoFactorEnabled = false,
                            UserName = "Martin Dvorsky"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "711d0104-9971-4e22-9ae3-1ff0aec9cf99",
                            CreatedAt = new DateTime(2024, 6, 6, 2, 32, 32, 402, DateTimeKind.Local).AddTicks(1846),
                            Email = "sebastianbach@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cb2b803e-1b9b-480f-9d34-b10e3d8fb77e",
                            TwoFactorEnabled = false,
                            UserName = "Sebastian Bach"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TaskTrackr.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TaskTrackr.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskTrackr.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TaskTrackr.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.HasOne("TaskTrackr.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskTrackr.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskTrackr.Models.Task", b =>
                {
                    b.HasOne("TaskTrackr.Models.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskTrackr.Models.User", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId");

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskTrackr.Models.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TaskTrackr.Models.User", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
