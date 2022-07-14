using System;
using System.Collections.Generic;

namespace listados
{
    class Program
    {
        static void Main(string[] args)
        {
        
        List<string> nombres = new List<string>();
        nombres.Add("Juan");
        nombres.Add("Pedro");
        nombres.Add("Maria");

        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        List<int> numeros = new List<int>();
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        foreach (var n in numeros)
        {
            Console.WriteLine(n);
        }

        List<Alumno> alumnos = new List<Alumno>();
        Alumno a = new Alumno(1, "Juan");
        Alumno b = new Alumno(2, "Pedro");
        Alumno c = new Alumno(3, "Maria");

        alumnos.Add(a);
        alumnos.Add(b);
        alumnos.Add(c);

        foreach (var alumno in alumnos)
        {
            Console.WriteLine(alumno.ID + " " + alumno.Nombre);
        }






        }       
    }
}