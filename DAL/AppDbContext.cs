using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grupa> Groups { get; set; }
        public DbSet<Historia> History { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Grupa)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.IDGrupy)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Grupa>().HasData(
                       new Grupa { ID = 1, Name = "Informatyka" },
                       new Grupa { ID = 2, Name = "Matematyka" },
                       new Grupa { ID = 3, Name = "Fizyka" },
                       new Grupa { ID = 4, Name = "Chemia" },
                       new Grupa { ID = 5, Name = "Biologia" },
                       new Grupa { ID = 6, Name = "Ekonomia" },
                       new Grupa { ID = 7, Name = "Psychologia" },
                       new Grupa { ID = 8, Name = "Filozofia" },
                       new Grupa { ID = 9, Name = "Historia" },
                       new Grupa { ID = 10, Name = "Prawo" }
                   );


            modelBuilder.Entity<Student>().HasData(
                new Student { ID = 1, Imie = "Jan", Nazwisko = "Kowalski", IDGrupy = 1 },
                new Student { ID = 2, Imie = "Anna", Nazwisko = "Nowak", IDGrupy = 1 },
                new Student { ID = 3, Imie = "Piotr", Nazwisko = "Wiśniewski", IDGrupy = 2 },
                new Student { ID = 4, Imie = "Katarzyna", Nazwisko = "Wójcik", IDGrupy = 2 },
                new Student { ID = 5, Imie = "Michał", Nazwisko = "Kowalczyk", IDGrupy = 3 },
                new Student { ID = 6, Imie = "Agnieszka", Nazwisko = "Kamińska", IDGrupy = 3 },
                new Student { ID = 7, Imie = "Tomasz", Nazwisko = "Lewandowski", IDGrupy = 4 },
                new Student { ID = 8, Imie = "Magdalena", Nazwisko = "Dąbrowska", IDGrupy = 4 },
                new Student { ID = 9, Imie = "Marcin", Nazwisko = "Zieliński", IDGrupy = 5 },
                new Student { ID = 10, Imie = "Monika", Nazwisko = "Szymańska", IDGrupy = 5 },
                new Student { ID = 11, Imie = "Adam", Nazwisko = "Woźniak", IDGrupy = 6 },
                new Student { ID = 12, Imie = "Barbara", Nazwisko = "Kozłowska", IDGrupy = 6 },
                new Student { ID = 13, Imie = "Grzegorz", Nazwisko = "Jankowski", IDGrupy = 7 },
                new Student { ID = 14, Imie = "Ewa", Nazwisko = "Mazur", IDGrupy = 7 },
                new Student { ID = 15, Imie = "Dariusz", Nazwisko = "Kwiatkowski", IDGrupy = 8 },
                new Student { ID = 16, Imie = "Joanna", Nazwisko = "Grabowska", IDGrupy = 8 },
                new Student { ID = 17, Imie = "Robert", Nazwisko = "Kaczmarek", IDGrupy = 9 },
                new Student { ID = 18, Imie = "Aleksandra", Nazwisko = "Pawlak", IDGrupy = 9 },
                new Student { ID = 19, Imie = "Paweł", Nazwisko = "Michalak", IDGrupy = 10 },
                new Student { ID = 20, Imie = "Natalia", Nazwisko = "Nowicka", IDGrupy = 10 },
                new Student { ID = 21, Imie = "Krzysztof", Nazwisko = "Adamczyk", IDGrupy = null },
                new Student { ID = 22, Imie = "Weronika", Nazwisko = "Dudek", IDGrupy = null },
                new Student { ID = 23, Imie = "Łukasz", Nazwisko = "Stępień", IDGrupy = null },
                new Student { ID = 24, Imie = "Karolina", Nazwisko = "Wróbel", IDGrupy = null }
            );


            modelBuilder.Entity<Historia>().HasData(
                new Historia { ID = 1, Imie = "Jan", Nazwisko = "Kowalski", IDGrupy = 1, TypAkcji = "edit", Data = new DateTime(2023, 10, 1) },
                new Historia { ID = 2, Imie = "Anna", Nazwisko = "Nowak", IDGrupy = 1, TypAkcji = "delete", Data = new DateTime(2023, 10, 2) },
                new Historia { ID = 3, Imie = "Piotr", Nazwisko = "Wiśniewski", IDGrupy = 2, TypAkcji = "edit", Data = new DateTime(2023, 10, 3) },
                new Historia { ID = 4, Imie = "Katarzyna", Nazwisko = "Wójcik", IDGrupy = 2, TypAkcji = "edit", Data = new DateTime(2023, 10, 4) },
                new Historia { ID = 5, Imie = "Michał", Nazwisko = "Kowalczyk", IDGrupy = 3, TypAkcji = "delete", Data = new DateTime(2023, 10, 5) },
                new Historia { ID = 6, Imie = "Agnieszka", Nazwisko = "Kamińska", IDGrupy = 3, TypAkcji = "edit", Data = new DateTime(2023, 10, 6) },
                new Historia { ID = 7, Imie = "Tomasz", Nazwisko = "Lewandowski", IDGrupy = 4, TypAkcji = "delete", Data = new DateTime(2023, 10, 7) },
                new Historia { ID = 8, Imie = "Magdalena", Nazwisko = "Dąbrowska", IDGrupy = 4, TypAkcji = "edit", Data = new DateTime(2023, 10, 8) },
                new Historia { ID = 9, Imie = "Marcin", Nazwisko = "Zieliński", IDGrupy = 5, TypAkcji = "edit", Data = new DateTime(2023, 10, 9) },
                new Historia { ID = 10, Imie = "Monika", Nazwisko = "Szymańska", IDGrupy = 5, TypAkcji = "delete", Data = new DateTime(2023, 10, 10) },
                new Historia { ID = 11, Imie = "Adam", Nazwisko = "Woźniak", IDGrupy = 6, TypAkcji = "edit", Data = new DateTime(2023, 10, 11) },
                new Historia { ID = 12, Imie = "Barbara", Nazwisko = "Kozłowska", IDGrupy = 6, TypAkcji = "edit", Data = new DateTime(2023, 10, 12) },
                new Historia { ID = 13, Imie = "Grzegorz", Nazwisko = "Jankowski", IDGrupy = 7, TypAkcji = "delete", Data = new DateTime(2023, 10, 13) },
                new Historia { ID = 14, Imie = "Ewa", Nazwisko = "Mazur", IDGrupy = 7, TypAkcji = "edit", Data = new DateTime(2023, 10, 14) },
                new Historia { ID = 15, Imie = "Dariusz", Nazwisko = "Kwiatkowski", IDGrupy = 8, TypAkcji = "edit", Data = new DateTime(2023, 10, 15) }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}