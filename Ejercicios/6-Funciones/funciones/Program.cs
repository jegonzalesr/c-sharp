using System;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(1, "Juan", "Perez");

            Console.WriteLine(a.nombreCompleto);
        }
    }
}