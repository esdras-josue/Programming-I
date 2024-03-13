using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Clase de Estudiante:
               Crea una clase llamada `Estudiante` que tenga atributos como nombre, edad,
               grado, y promedio. Luego, crea métodos para imprimir la información del
               estudiante, calcular su calificación (Aprobado o Reprobado) basado en su
               promedio y otro método para incrementar su promedio si el estudiante ha pasado
             * a un nuevo grado.
             */
            
            int opcion;

            List<Estudiante> estudiantes = new List<Estudiante>();

            do
            {
                Menu();
                opcion = int.Parse(Console.ReadLine());

                if(opcion == 1)
                {
                    Estudiante estudiante = new Estudiante();
                    Console.WriteLine("Ingrese su nombre");
                    estudiante.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su edad:");
                    estudiante.Edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su grado:");
                    estudiante.Grado = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese sus calificaciones: ");
                    estudiante.Calificaciones = int.Parse(Console.ReadLine());

                    estudiantes.Add(estudiante);
                }
                
            }
            while (opcion != 0);

            Console.WriteLine();
            Console.WriteLine();
          
            foreach(Estudiante estudianteDatos in estudiantes)
            {
                Console.WriteLine("******Resultado******");
                Console.WriteLine("Nombre: " + estudianteDatos.Nombre);
                Console.WriteLine("Edad: " + estudianteDatos.Edad);
                Console.WriteLine("Grado: " + estudianteDatos.Grado);
                Console.WriteLine("Calificacion: " + estudianteDatos.Calificaciones);
                Console.WriteLine("Estatus: " + estudianteDatos.Estatus);
                if(estudianteDatos.Estatus == "Aprobado")
                {
                    double nuevoPromedio = estudianteDatos.IncrementarPromedio(75);
                    Console.WriteLine("Nuevo Promedio: " + nuevoPromedio);
                }
                
                Console.WriteLine();
            }

            Console.ReadKey();  
        }

        public static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0. salir");
            Console.WriteLine("1. Ingresar calificaciones");
        }
    }
}
