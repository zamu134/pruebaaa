using consulta_a_la_base_de_dato;
using System;
using System.Linq;
using consulta_a_la_base_de_dato; // Asegúrate de tener acceso a tu contexto y modelo de datos
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using (var context = new UNABDbContext())
        {
            // Consulta y muestra todos los estudiantes en la base de datos
            var estudiantes = context.Students.ToList();

            Console.WriteLine("Datos de Estudiantes:");
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"ID: {estudiante.Id}, Nombres: {estudiante.Nombres}, Apellidos: {estudiante.Apellidos}, Edad: {estudiante.Edad}, Sexo: {estudiante.Sexo}");
            }
        }
    }
}