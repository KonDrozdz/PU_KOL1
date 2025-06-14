﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250425174622_FirstIter")]
    partial class FirstIter
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Models.Grupa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Informatyka"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Matematyka"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Fizyka"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Chemia"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Biologia"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Ekonomia"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Psychologia"
                        },
                        new
                        {
                            ID = 8,
                            Name = "Filozofia"
                        },
                        new
                        {
                            ID = 9,
                            Name = "Historia"
                        },
                        new
                        {
                            ID = 10,
                            Name = "Prawo"
                        });
                });

            modelBuilder.Entity("DAL.Models.Historia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ActionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IDGrupy")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("History");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 4, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 8,
                            Imie = "Student11",
                            Nazwisko = "Nazwisko11"
                        },
                        new
                        {
                            ID = 2,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 4, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 2,
                            Imie = "Student16",
                            Nazwisko = "Nazwisko16"
                        },
                        new
                        {
                            ID = 3,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 3, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 4,
                            Imie = "Student10",
                            Nazwisko = "Nazwisko10"
                        },
                        new
                        {
                            ID = 4,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 15, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 5,
                            Imie = "Student5",
                            Nazwisko = "Nazwisko5"
                        },
                        new
                        {
                            ID = 5,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 14, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 10,
                            Imie = "Student19",
                            Nazwisko = "Nazwisko19"
                        },
                        new
                        {
                            ID = 6,
                            ActionType = "edit",
                            Date = new DateTime(2025, 3, 29, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 8,
                            Imie = "Student21",
                            Nazwisko = "Nazwisko21"
                        },
                        new
                        {
                            ID = 7,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 8, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 2,
                            Imie = "Student10",
                            Nazwisko = "Nazwisko10"
                        },
                        new
                        {
                            ID = 8,
                            ActionType = "delete",
                            Date = new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 5,
                            Imie = "Student7",
                            Nazwisko = "Nazwisko7"
                        },
                        new
                        {
                            ID = 9,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 7, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 2,
                            Imie = "Student16",
                            Nazwisko = "Nazwisko16"
                        },
                        new
                        {
                            ID = 10,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 13, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 10,
                            Imie = "Student18",
                            Nazwisko = "Nazwisko18"
                        },
                        new
                        {
                            ID = 11,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 11, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 2,
                            Imie = "Student19",
                            Nazwisko = "Nazwisko19"
                        },
                        new
                        {
                            ID = 12,
                            ActionType = "delete",
                            Date = new DateTime(2025, 3, 28, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 4,
                            Imie = "Student1",
                            Nazwisko = "Nazwisko1"
                        },
                        new
                        {
                            ID = 13,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 1, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 8,
                            Imie = "Student3",
                            Nazwisko = "Nazwisko3"
                        },
                        new
                        {
                            ID = 14,
                            ActionType = "delete",
                            Date = new DateTime(2025, 3, 28, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 9,
                            Imie = "Student22",
                            Nazwisko = "Nazwisko22"
                        },
                        new
                        {
                            ID = 15,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 19, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 8,
                            Imie = "Student1",
                            Nazwisko = "Nazwisko1"
                        },
                        new
                        {
                            ID = 16,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 4,
                            Imie = "Student12",
                            Nazwisko = "Nazwisko12"
                        },
                        new
                        {
                            ID = 17,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 9, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 4,
                            Imie = "Student5",
                            Nazwisko = "Nazwisko5"
                        },
                        new
                        {
                            ID = 18,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 7, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 4,
                            Imie = "Student5",
                            Nazwisko = "Nazwisko5"
                        },
                        new
                        {
                            ID = 19,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 10,
                            Imie = "Student4",
                            Nazwisko = "Nazwisko4"
                        },
                        new
                        {
                            ID = 20,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 1, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 10,
                            Imie = "Student13",
                            Nazwisko = "Nazwisko13"
                        },
                        new
                        {
                            ID = 21,
                            ActionType = "edit",
                            Date = new DateTime(2025, 3, 26, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 6,
                            Imie = "Student19",
                            Nazwisko = "Nazwisko19"
                        },
                        new
                        {
                            ID = 22,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 5, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 6,
                            Imie = "Student6",
                            Nazwisko = "Nazwisko6"
                        },
                        new
                        {
                            ID = 23,
                            ActionType = "edit",
                            Date = new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 10,
                            Imie = "Student12",
                            Nazwisko = "Nazwisko12"
                        },
                        new
                        {
                            ID = 24,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 23, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 6,
                            Imie = "Student22",
                            Nazwisko = "Nazwisko22"
                        },
                        new
                        {
                            ID = 25,
                            ActionType = "delete",
                            Date = new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 5,
                            Imie = "Student22",
                            Nazwisko = "Nazwisko22"
                        },
                        new
                        {
                            ID = 26,
                            ActionType = "edit",
                            Date = new DateTime(2025, 3, 29, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 4,
                            Imie = "Student5",
                            Nazwisko = "Nazwisko5"
                        },
                        new
                        {
                            ID = 27,
                            ActionType = "edit",
                            Date = new DateTime(2025, 3, 31, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 2,
                            Imie = "Student21",
                            Nazwisko = "Nazwisko21"
                        },
                        new
                        {
                            ID = 28,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 2,
                            Imie = "Student9",
                            Nazwisko = "Nazwisko9"
                        },
                        new
                        {
                            ID = 29,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 5,
                            Imie = "Student17",
                            Nazwisko = "Nazwisko17"
                        },
                        new
                        {
                            ID = 30,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 16, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 3,
                            Imie = "Student22",
                            Nazwisko = "Nazwisko22"
                        },
                        new
                        {
                            ID = 31,
                            ActionType = "delete",
                            Date = new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 1,
                            Imie = "Student16",
                            Nazwisko = "Nazwisko16"
                        },
                        new
                        {
                            ID = 32,
                            ActionType = "edit",
                            Date = new DateTime(2025, 3, 26, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 9,
                            Imie = "Student20",
                            Nazwisko = "Nazwisko20"
                        },
                        new
                        {
                            ID = 33,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 3, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 7,
                            Imie = "Student5",
                            Nazwisko = "Nazwisko5"
                        },
                        new
                        {
                            ID = 34,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 8,
                            Imie = "Student8",
                            Nazwisko = "Nazwisko8"
                        },
                        new
                        {
                            ID = 35,
                            ActionType = "delete",
                            Date = new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 3,
                            Imie = "Student6",
                            Nazwisko = "Nazwisko6"
                        },
                        new
                        {
                            ID = 36,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 3, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 6,
                            Imie = "Student18",
                            Nazwisko = "Nazwisko18"
                        },
                        new
                        {
                            ID = 37,
                            ActionType = "edit",
                            Date = new DateTime(2025, 3, 31, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 8,
                            Imie = "Student20",
                            Nazwisko = "Nazwisko20"
                        },
                        new
                        {
                            ID = 38,
                            ActionType = "delete",
                            Date = new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 5,
                            Imie = "Student4",
                            Nazwisko = "Nazwisko4"
                        },
                        new
                        {
                            ID = 39,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 6, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 4,
                            Imie = "Student18",
                            Nazwisko = "Nazwisko18"
                        },
                        new
                        {
                            ID = 40,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 19, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 5,
                            Imie = "Student21",
                            Nazwisko = "Nazwisko21"
                        },
                        new
                        {
                            ID = 41,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 21, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 9,
                            Imie = "Student19",
                            Nazwisko = "Nazwisko19"
                        },
                        new
                        {
                            ID = 42,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 2, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 3,
                            Imie = "Student11",
                            Nazwisko = "Nazwisko11"
                        },
                        new
                        {
                            ID = 43,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 22, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 8,
                            Imie = "Student8",
                            Nazwisko = "Nazwisko8"
                        },
                        new
                        {
                            ID = 44,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 15, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 3,
                            Imie = "Student23",
                            Nazwisko = "Nazwisko23"
                        },
                        new
                        {
                            ID = 45,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 18, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 6,
                            Imie = "Student14",
                            Nazwisko = "Nazwisko14"
                        },
                        new
                        {
                            ID = 46,
                            ActionType = "delete",
                            Date = new DateTime(2025, 3, 26, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 4,
                            Imie = "Student11",
                            Nazwisko = "Nazwisko11"
                        },
                        new
                        {
                            ID = 47,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 19, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 5,
                            Imie = "Student14",
                            Nazwisko = "Nazwisko14"
                        },
                        new
                        {
                            ID = 48,
                            ActionType = "delete",
                            Date = new DateTime(2025, 3, 30, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 5,
                            Imie = "Student12",
                            Nazwisko = "Nazwisko12"
                        },
                        new
                        {
                            ID = 49,
                            ActionType = "edit",
                            Date = new DateTime(2025, 4, 3, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 9,
                            Imie = "Student5",
                            Nazwisko = "Nazwisko5"
                        },
                        new
                        {
                            ID = 50,
                            ActionType = "delete",
                            Date = new DateTime(2025, 4, 23, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808),
                            IDGrupy = 1,
                            Imie = "Student2",
                            Nazwisko = "Nazwisko2"
                        });
                });

            modelBuilder.Entity("DAL.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("IDGrupy")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDGrupy");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IDGrupy = 1,
                            Imie = "Jan",
                            Nazwisko = "Kowalski"
                        },
                        new
                        {
                            ID = 2,
                            IDGrupy = 1,
                            Imie = "Anna",
                            Nazwisko = "Nowak"
                        },
                        new
                        {
                            ID = 3,
                            IDGrupy = 2,
                            Imie = "Piotr",
                            Nazwisko = "Wiśniewski"
                        },
                        new
                        {
                            ID = 4,
                            IDGrupy = 2,
                            Imie = "Katarzyna",
                            Nazwisko = "Wójcik"
                        },
                        new
                        {
                            ID = 5,
                            IDGrupy = 3,
                            Imie = "Michał",
                            Nazwisko = "Kowalczyk"
                        },
                        new
                        {
                            ID = 6,
                            IDGrupy = 3,
                            Imie = "Agnieszka",
                            Nazwisko = "Kamińska"
                        },
                        new
                        {
                            ID = 7,
                            IDGrupy = 4,
                            Imie = "Tomasz",
                            Nazwisko = "Lewandowski"
                        },
                        new
                        {
                            ID = 8,
                            IDGrupy = 4,
                            Imie = "Magdalena",
                            Nazwisko = "Dąbrowska"
                        },
                        new
                        {
                            ID = 9,
                            IDGrupy = 5,
                            Imie = "Marcin",
                            Nazwisko = "Zieliński"
                        },
                        new
                        {
                            ID = 10,
                            IDGrupy = 5,
                            Imie = "Monika",
                            Nazwisko = "Szymańska"
                        },
                        new
                        {
                            ID = 11,
                            IDGrupy = 6,
                            Imie = "Adam",
                            Nazwisko = "Woźniak"
                        },
                        new
                        {
                            ID = 12,
                            IDGrupy = 6,
                            Imie = "Barbara",
                            Nazwisko = "Kozłowska"
                        },
                        new
                        {
                            ID = 13,
                            IDGrupy = 7,
                            Imie = "Grzegorz",
                            Nazwisko = "Jankowski"
                        },
                        new
                        {
                            ID = 14,
                            IDGrupy = 7,
                            Imie = "Ewa",
                            Nazwisko = "Mazur"
                        },
                        new
                        {
                            ID = 15,
                            IDGrupy = 8,
                            Imie = "Dariusz",
                            Nazwisko = "Kwiatkowski"
                        },
                        new
                        {
                            ID = 16,
                            IDGrupy = 8,
                            Imie = "Joanna",
                            Nazwisko = "Grabowska"
                        },
                        new
                        {
                            ID = 17,
                            IDGrupy = 9,
                            Imie = "Robert",
                            Nazwisko = "Kaczmarek"
                        },
                        new
                        {
                            ID = 18,
                            IDGrupy = 9,
                            Imie = "Aleksandra",
                            Nazwisko = "Pawlak"
                        },
                        new
                        {
                            ID = 19,
                            IDGrupy = 10,
                            Imie = "Paweł",
                            Nazwisko = "Michalak"
                        },
                        new
                        {
                            ID = 20,
                            IDGrupy = 10,
                            Imie = "Natalia",
                            Nazwisko = "Nowicka"
                        },
                        new
                        {
                            ID = 21,
                            Imie = "Krzysztof",
                            Nazwisko = "Adamczyk"
                        },
                        new
                        {
                            ID = 22,
                            Imie = "Weronika",
                            Nazwisko = "Dudek"
                        },
                        new
                        {
                            ID = 23,
                            Imie = "Łukasz",
                            Nazwisko = "Stępień"
                        },
                        new
                        {
                            ID = 24,
                            Imie = "Karolina",
                            Nazwisko = "Wróbel"
                        });
                });

            modelBuilder.Entity("DAL.Models.Student", b =>
                {
                    b.HasOne("DAL.Models.Grupa", "Grupa")
                        .WithMany("Students")
                        .HasForeignKey("IDGrupy")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Grupa");
                });

            modelBuilder.Entity("DAL.Models.Grupa", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
