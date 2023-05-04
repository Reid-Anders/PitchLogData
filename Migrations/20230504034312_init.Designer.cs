﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PitchLogData;

#nullable disable

namespace PitchLogData.Migrations
{
    [DbContext(typeof(PitchLogContext))]
    [Migration("20230504034312_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PitchLogLib.Entities.Area", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NearestTown")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("PitchLogLib.Entities.BoulderProblem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("GradeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PadsRequired")
                        .HasColumnType("int");

                    b.Property<int>("SectorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GradeID");

                    b.HasIndex("SectorID");

                    b.ToTable("Boulders");
                });

            modelBuilder.Entity("PitchLogLib.Entities.BoulderSession", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("Send")
                        .HasColumnType("bit");

                    b.Property<int>("SessionLength")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("BoulderSessions");
                });

            modelBuilder.Entity("PitchLogLib.Entities.Grade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Grade");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Type = 1,
                            Value = "5.5"
                        },
                        new
                        {
                            ID = 2,
                            Type = 1,
                            Value = "5.6"
                        },
                        new
                        {
                            ID = 3,
                            Type = 1,
                            Value = "5.7"
                        },
                        new
                        {
                            ID = 4,
                            Type = 1,
                            Value = "5.8"
                        },
                        new
                        {
                            ID = 5,
                            Type = 1,
                            Value = "5.9"
                        },
                        new
                        {
                            ID = 6,
                            Type = 1,
                            Value = "5.10a"
                        },
                        new
                        {
                            ID = 7,
                            Type = 1,
                            Value = "5.10b"
                        },
                        new
                        {
                            ID = 8,
                            Type = 1,
                            Value = "5.10c"
                        },
                        new
                        {
                            ID = 9,
                            Type = 1,
                            Value = "5.10d"
                        },
                        new
                        {
                            ID = 10,
                            Type = 1,
                            Value = "5.11a"
                        },
                        new
                        {
                            ID = 11,
                            Type = 1,
                            Value = "5.11b"
                        },
                        new
                        {
                            ID = 12,
                            Type = 1,
                            Value = "5.11c"
                        },
                        new
                        {
                            ID = 13,
                            Type = 1,
                            Value = "5.11d"
                        },
                        new
                        {
                            ID = 14,
                            Type = 1,
                            Value = "5.12a"
                        },
                        new
                        {
                            ID = 15,
                            Type = 1,
                            Value = "5.12b"
                        },
                        new
                        {
                            ID = 16,
                            Type = 1,
                            Value = "5.12c"
                        },
                        new
                        {
                            ID = 17,
                            Type = 1,
                            Value = "5.12d"
                        },
                        new
                        {
                            ID = 18,
                            Type = 1,
                            Value = "5.13a"
                        },
                        new
                        {
                            ID = 19,
                            Type = 1,
                            Value = "5.13b"
                        },
                        new
                        {
                            ID = 20,
                            Type = 1,
                            Value = "5.13c"
                        },
                        new
                        {
                            ID = 21,
                            Type = 1,
                            Value = "5.13d"
                        },
                        new
                        {
                            ID = 22,
                            Type = 1,
                            Value = "5.14a"
                        },
                        new
                        {
                            ID = 23,
                            Type = 1,
                            Value = "5.14b"
                        },
                        new
                        {
                            ID = 24,
                            Type = 1,
                            Value = "5.14c"
                        },
                        new
                        {
                            ID = 25,
                            Type = 1,
                            Value = "5.14d"
                        },
                        new
                        {
                            ID = 26,
                            Type = 1,
                            Value = "5.15a"
                        },
                        new
                        {
                            ID = 27,
                            Type = 1,
                            Value = "5.15b"
                        },
                        new
                        {
                            ID = 28,
                            Type = 1,
                            Value = "5.15c"
                        },
                        new
                        {
                            ID = 29,
                            Type = 1,
                            Value = "5.15d"
                        },
                        new
                        {
                            ID = 30,
                            Type = 4,
                            Value = "V0"
                        },
                        new
                        {
                            ID = 31,
                            Type = 4,
                            Value = "V1"
                        },
                        new
                        {
                            ID = 32,
                            Type = 4,
                            Value = "V2"
                        },
                        new
                        {
                            ID = 33,
                            Type = 4,
                            Value = "V3"
                        },
                        new
                        {
                            ID = 34,
                            Type = 4,
                            Value = "V4"
                        },
                        new
                        {
                            ID = 35,
                            Type = 4,
                            Value = "V5"
                        },
                        new
                        {
                            ID = 36,
                            Type = 4,
                            Value = "V6"
                        },
                        new
                        {
                            ID = 37,
                            Type = 4,
                            Value = "V7"
                        },
                        new
                        {
                            ID = 38,
                            Type = 4,
                            Value = "V8"
                        },
                        new
                        {
                            ID = 39,
                            Type = 4,
                            Value = "V9"
                        },
                        new
                        {
                            ID = 40,
                            Type = 4,
                            Value = "V10"
                        },
                        new
                        {
                            ID = 41,
                            Type = 4,
                            Value = "V11"
                        },
                        new
                        {
                            ID = 42,
                            Type = 4,
                            Value = "V12"
                        },
                        new
                        {
                            ID = 43,
                            Type = 4,
                            Value = "V13"
                        },
                        new
                        {
                            ID = 44,
                            Type = 4,
                            Value = "V14"
                        },
                        new
                        {
                            ID = 45,
                            Type = 4,
                            Value = "V15"
                        },
                        new
                        {
                            ID = 46,
                            Type = 4,
                            Value = "V16"
                        },
                        new
                        {
                            ID = 47,
                            Type = 4,
                            Value = "V17"
                        });
                });

            modelBuilder.Entity("PitchLogLib.Entities.Pitch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Partner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Pitches");
                });

            modelBuilder.Entity("PitchLogLib.Entities.Route", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("GradeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GradeID");

                    b.HasIndex("SectorID");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("PitchLogLib.Entities.Sector", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("Approach")
                        .HasColumnType("int");

                    b.Property<int>("AreaID")
                        .HasColumnType("int");

                    b.Property<int>("Aspect")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AreaID");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("PitchLogLib.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PitchLogLib.Entities.BoulderProblem", b =>
                {
                    b.HasOne("PitchLogLib.Entities.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PitchLogLib.Entities.Sector", "Sector")
                        .WithMany("BoulderProblems")
                        .HasForeignKey("SectorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("PitchLogLib.Entities.BoulderSession", b =>
                {
                    b.HasOne("PitchLogLib.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PitchLogLib.Entities.Pitch", b =>
                {
                    b.HasOne("PitchLogLib.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PitchLogLib.Entities.Route", b =>
                {
                    b.HasOne("PitchLogLib.Entities.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PitchLogLib.Entities.Sector", "Sector")
                        .WithMany("Routes")
                        .HasForeignKey("SectorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("PitchLogLib.Entities.Length", "Length", b1 =>
                        {
                            b1.Property<int>("RouteID")
                                .HasColumnType("int");

                            b1.Property<int>("Units")
                                .HasColumnType("int")
                                .HasColumnName("LengthUnits");

                            b1.Property<int>("Value")
                                .HasColumnType("int")
                                .HasColumnName("Length");

                            b1.HasKey("RouteID");

                            b1.ToTable("Routes");

                            b1.WithOwner()
                                .HasForeignKey("RouteID");
                        });

                    b.Navigation("Grade");

                    b.Navigation("Length");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("PitchLogLib.Entities.Sector", b =>
                {
                    b.HasOne("PitchLogLib.Entities.Area", "Area")
                        .WithMany("Sectors")
                        .HasForeignKey("AreaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("PitchLogLib.Entities.Area", b =>
                {
                    b.Navigation("Sectors");
                });

            modelBuilder.Entity("PitchLogLib.Entities.Sector", b =>
                {
                    b.Navigation("BoulderProblems");

                    b.Navigation("Routes");
                });
#pragma warning restore 612, 618
        }
    }
}
