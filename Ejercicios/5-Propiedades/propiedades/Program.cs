using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.id = 1;
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";


            Alumno b = new Alumno();
            b.id = 2;
            b.PrimerNombre = "Pedro";
            b.SegundoNombre = "Perez";

            Alumno c = new Alumno(3);
            b.PrimerNombre = "Jose";

            Console.WriteLine(a.PrimerNombre);
            Console.WriteLine(b.PrimerNombre);
        }
    }
}