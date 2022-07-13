using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";


            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Pedro";
            b.SegundoNombre = "Martinez";

            Alumno c = new Alumno(3);
            b.PrimerNombre = "Jose";
            
            Alumno d = new Alumno("Juan", "Jimenez");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(d.PrimerNombre+" "+d.SegundoNombre);
        }
    }
}