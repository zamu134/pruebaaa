using consulta_a_la_base_de_dato;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<EstudianteUNAB> Estudiante{ get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-TI4U9D2\\ZAMU;Database=Program2;Trusted_Connection=True;");
        }
    }
}