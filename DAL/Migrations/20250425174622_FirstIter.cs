using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class FirstIter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GrupaID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GrupaID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GrupaID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "History",
                newName: "Nazwisko");

            migrationBuilder.RenameColumn(
                name: "GroupID",
                table: "History",
                newName: "IDGrupy");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "History",
                newName: "Imie");

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Informatyka" },
                    { 2, "Matematyka" },
                    { 3, "Fizyka" },
                    { 4, "Chemia" },
                    { 5, "Biologia" },
                    { 6, "Ekonomia" },
                    { 7, "Psychologia" },
                    { 8, "Filozofia" },
                    { 9, "Historia" },
                    { 10, "Prawo" }
                });

            migrationBuilder.InsertData(
                table: "History",
                columns: new[] { "ID", "ActionType", "Date", "IDGrupy", "Imie", "Nazwisko" },
                values: new object[,]
                {
                    { 1, "delete", new DateTime(2025, 4, 4, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 8, "Student11", "Nazwisko11" },
                    { 2, "delete", new DateTime(2025, 4, 4, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 2, "Student16", "Nazwisko16" },
                    { 3, "edit", new DateTime(2025, 4, 3, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 4, "Student10", "Nazwisko10" },
                    { 4, "delete", new DateTime(2025, 4, 15, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 5, "Student5", "Nazwisko5" },
                    { 5, "edit", new DateTime(2025, 4, 14, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 10, "Student19", "Nazwisko19" },
                    { 6, "edit", new DateTime(2025, 3, 29, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 8, "Student21", "Nazwisko21" },
                    { 7, "delete", new DateTime(2025, 4, 8, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 2, "Student10", "Nazwisko10" },
                    { 8, "delete", new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 5, "Student7", "Nazwisko7" },
                    { 9, "delete", new DateTime(2025, 4, 7, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 2, "Student16", "Nazwisko16" },
                    { 10, "delete", new DateTime(2025, 4, 13, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 10, "Student18", "Nazwisko18" },
                    { 11, "delete", new DateTime(2025, 4, 11, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 2, "Student19", "Nazwisko19" },
                    { 12, "delete", new DateTime(2025, 3, 28, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 4, "Student1", "Nazwisko1" },
                    { 13, "delete", new DateTime(2025, 4, 1, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 8, "Student3", "Nazwisko3" },
                    { 14, "delete", new DateTime(2025, 3, 28, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 9, "Student22", "Nazwisko22" },
                    { 15, "edit", new DateTime(2025, 4, 19, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 8, "Student1", "Nazwisko1" },
                    { 16, "delete", new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 4, "Student12", "Nazwisko12" },
                    { 17, "edit", new DateTime(2025, 4, 9, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 4, "Student5", "Nazwisko5" },
                    { 18, "delete", new DateTime(2025, 4, 7, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 4, "Student5", "Nazwisko5" },
                    { 19, "edit", new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 10, "Student4", "Nazwisko4" },
                    { 20, "edit", new DateTime(2025, 4, 1, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 10, "Student13", "Nazwisko13" },
                    { 21, "edit", new DateTime(2025, 3, 26, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 6, "Student19", "Nazwisko19" },
                    { 22, "delete", new DateTime(2025, 4, 5, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 6, "Student6", "Nazwisko6" },
                    { 23, "edit", new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 10, "Student12", "Nazwisko12" },
                    { 24, "delete", new DateTime(2025, 4, 23, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 6, "Student22", "Nazwisko22" },
                    { 25, "delete", new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 5, "Student22", "Nazwisko22" },
                    { 26, "edit", new DateTime(2025, 3, 29, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 4, "Student5", "Nazwisko5" },
                    { 27, "edit", new DateTime(2025, 3, 31, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 2, "Student21", "Nazwisko21" },
                    { 28, "delete", new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 2, "Student9", "Nazwisko9" },
                    { 29, "edit", new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 5, "Student17", "Nazwisko17" },
                    { 30, "edit", new DateTime(2025, 4, 16, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 3, "Student22", "Nazwisko22" },
                    { 31, "delete", new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 1, "Student16", "Nazwisko16" },
                    { 32, "edit", new DateTime(2025, 3, 26, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 9, "Student20", "Nazwisko20" },
                    { 33, "edit", new DateTime(2025, 4, 3, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 7, "Student5", "Nazwisko5" },
                    { 34, "delete", new DateTime(2025, 4, 24, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 8, "Student8", "Nazwisko8" },
                    { 35, "delete", new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 3, "Student6", "Nazwisko6" },
                    { 36, "delete", new DateTime(2025, 4, 3, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 6, "Student18", "Nazwisko18" },
                    { 37, "edit", new DateTime(2025, 3, 31, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 8, "Student20", "Nazwisko20" },
                    { 38, "delete", new DateTime(2025, 3, 27, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 5, "Student4", "Nazwisko4" },
                    { 39, "delete", new DateTime(2025, 4, 6, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 4, "Student18", "Nazwisko18" },
                    { 40, "edit", new DateTime(2025, 4, 19, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 5, "Student21", "Nazwisko21" },
                    { 41, "delete", new DateTime(2025, 4, 21, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 9, "Student19", "Nazwisko19" },
                    { 42, "delete", new DateTime(2025, 4, 2, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 3, "Student11", "Nazwisko11" },
                    { 43, "delete", new DateTime(2025, 4, 22, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 8, "Student8", "Nazwisko8" },
                    { 44, "edit", new DateTime(2025, 4, 15, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 3, "Student23", "Nazwisko23" },
                    { 45, "edit", new DateTime(2025, 4, 18, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 6, "Student14", "Nazwisko14" },
                    { 46, "delete", new DateTime(2025, 3, 26, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 4, "Student11", "Nazwisko11" },
                    { 47, "edit", new DateTime(2025, 4, 19, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 5, "Student14", "Nazwisko14" },
                    { 48, "delete", new DateTime(2025, 3, 30, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 5, "Student12", "Nazwisko12" },
                    { 49, "edit", new DateTime(2025, 4, 3, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 9, "Student5", "Nazwisko5" },
                    { 50, "delete", new DateTime(2025, 4, 23, 19, 46, 21, 693, DateTimeKind.Local).AddTicks(1808), 1, "Student2", "Nazwisko2" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "IDGrupy", "Imie", "Nazwisko" },
                values: new object[,]
                {
                    { 21, null, "Krzysztof", "Adamczyk" },
                    { 22, null, "Weronika", "Dudek" },
                    { 23, null, "Łukasz", "Stępień" },
                    { 24, null, "Karolina", "Wróbel" },
                    { 1, 1, "Jan", "Kowalski" },
                    { 2, 1, "Anna", "Nowak" },
                    { 3, 2, "Piotr", "Wiśniewski" },
                    { 4, 2, "Katarzyna", "Wójcik" },
                    { 5, 3, "Michał", "Kowalczyk" },
                    { 6, 3, "Agnieszka", "Kamińska" },
                    { 7, 4, "Tomasz", "Lewandowski" },
                    { 8, 4, "Magdalena", "Dąbrowska" },
                    { 9, 5, "Marcin", "Zieliński" },
                    { 10, 5, "Monika", "Szymańska" },
                    { 11, 6, "Adam", "Woźniak" },
                    { 12, 6, "Barbara", "Kozłowska" },
                    { 13, 7, "Grzegorz", "Jankowski" },
                    { 14, 7, "Ewa", "Mazur" },
                    { 15, 8, "Dariusz", "Kwiatkowski" },
                    { 16, 8, "Joanna", "Grabowska" },
                    { 17, 9, "Robert", "Kaczmarek" },
                    { 18, 9, "Aleksandra", "Pawlak" },
                    { 19, 10, "Paweł", "Michalak" },
                    { 20, 10, "Natalia", "Nowicka" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "Nazwisko",
                table: "History",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Imie",
                table: "History",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "IDGrupy",
                table: "History",
                newName: "GroupID");

            migrationBuilder.AddColumn<int>(
                name: "GrupaID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_GrupaID",
                table: "Students",
                column: "GrupaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GrupaID",
                table: "Students",
                column: "GrupaID",
                principalTable: "Groups",
                principalColumn: "ID");
        }
    }
}
