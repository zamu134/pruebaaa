using consulta_a_la_base_de_dato;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


class Program
{
    static void Main()
    {
        while (true)
        {
            using (var context = new Context())
            {
                Console.WriteLine("Lista de Estudiantes:");
                foreach (var estudiante in context.Estudiante.ToList())
                {
                    Console.WriteLine($"ID: {estudiante.Id}, Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}, Sexo: {estudiante.Sexo}");
                }
            }

            Console.WriteLine("\nIngrese los datos de los nuevos estudiantes:");

            Console.Write("Nombre: ");
            var nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            var apellido = Console.ReadLine();

            Console.Write("Sexo: ");
            var sexo = Console.ReadLine();

            Console.Write("Edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                var nuevoEstudiante = new EstudianteUNAB
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Sexo = sexo,
                    Edad = edad
                };

                using (var context = new Context())
                {
                    try
                    {
                        context.Estudiante.Add(nuevoEstudiante);
                        context.SaveChanges();
                        Console.WriteLine("Estudiante agregado correctamente.");
                    }
                    catch (DbUpdateException ex)
                    {
                        Console.WriteLine("Error al agregar estudiante. Asegúrate de que los datos sean válidos.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Edad no válida. Intente nuevamente.");
            }

            Console.Write("¿Si de sea agregar mas estudiante presione (S) y si ya no de sea ingresar presione (N): ");
            var respuesta = Console.ReadLine();
            if (respuesta?.Trim().ToLower() != "s")
            {
                break;
            }
        }
    }
}