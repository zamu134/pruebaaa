using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using consulta_a_la_base_de_dato;

public class UNABDbContext : DbContext
{
    //entities
    public DbSet<Estudiante> Students { get; set; }
    //public DbSet<Grado> Grades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-TI4U9D2\\ZAMU\\mssqllocaldb;Database=Program2;Trusted_Connection=True;");
    }
}