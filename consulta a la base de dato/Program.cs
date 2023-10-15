using consulta_a_la_base_de_dato;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

//class Program
//{
    //    static void Main()
    //    {
    //        var options = new DbContextOptionsBuilder<Context>()
    //            .UseSqlServer("Server=DESKTOP-TI4U9D2\\ZAMU;Database=Program2;Trusted_Connection=True;")
    //            .Options;

    //        using (var context = new Context(options))
    //        {
    //            ConsultaBD consultaBD = new ConsultaBD();

    //            // Agregar un estudiante
    //            consultaBD.AgregarEstudiante("Juan Pérez", 20);

    //            // Consultar y listar estudiantes
    //            consultaBD.ListarEstudiantes();
    //        }
    //    }
    //}


    //    public class ConsultaBD
    //    {
    //        public void AgregarEstudiante(string nombre, int edad)
    //        {
    //            using (var context = new Context())
    //            {
    //                var nuevoEstudiante = new EstudianteUNAB { Nombre = nombre, Edad = edad };
    //                context.Estudiante.Add(nuevoEstudiante);
    //                context.SaveChanges();
    //            }
    //        }

    //        public void ListarEstudiantes()
    //        {
    //            using (var context = new Context())
    //            {
    //                Console.WriteLine("Lista de Estudiantes:");
    //                foreach (var EstudianteUNAB in context.Estudiante.ToList())
    //                {
    //                    Console.WriteLine($"ID: {EstudianteUNAB.Id}, Nombre: {EstudianteUNAB.Nombre}, Edad: {EstudianteUNAB.Edad}");
    //                }
    //            }
    //        }
    //    }
    //}


using (var context = new Context())
{
    foreach (var EstudianteUNAB in context.Estudiante.ToList())
    {
        Console.WriteLine($"ID: {EstudianteUNAB.Id}, Nombre: {EstudianteUNAB.Nombre}, Edad: {EstudianteUNAB.Edad}, Edad: {EstudianteUNAB.Sexo}");
    }

}

//using (var contextdb = new Context())
//{
//    contextdb.Database.EnsureCreated();
//    var estudiante1 = new EstudianteUNAB() { Nombre = "Pepito", Apellido = "Pérez" };
//    contextdb.Add(estudiante1);
//    contextdb.SaveChanges();
//    foreach (var s in contextdb.Estudiante)
//    {
//        Console.WriteLine(s.Apellido);

//    }
//}




using (var context = new Context())
{
    context.Database.EnsureCreated();

    {
        Console.Write("Nombre: ");
        var nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        var apellido = Console.ReadLine();

        Console.Write("Sexo: ");
        var sexo = Console.ReadLine();

        Console.Write("Edad: ");
        if (int.TryParse(Console.ReadLine(), out int edad))
        {
            var estudiante = new EstudianteUNAB() { Nombre = nombre, Apellido = apellido, Sexo = sexo, Edad = edad };
            context.Estudiante.Add(estudiante);
            context.SaveChanges();

            Console.WriteLine("Estudiante agregado correctamente.");

            Console.Write("¿Desea agregar más registros? (Sí/No): ");
            string respuesta = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Edad no válida. Intente nuevamente.");
        }
    }
}

  



