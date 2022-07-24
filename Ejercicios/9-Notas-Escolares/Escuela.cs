using System.Collections.Generic;
using System;

public class Escuela 
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public List<Alumno> ListaAlumnos { get; set; }


    public Escuela(int codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;

        Alumno a = new Alumno(1, "Juan", "55555");
        Alumno b = new Alumno(2, "Maria", "77777");
        Alumno c = new Alumno(3, "Pedro", "88888");
        Alumno d = new Alumno(4, "Jose", "99999");

        ListaAlumnos = new List<Alumno>();
        ListaAlumnos.Add(a);
        ListaAlumnos.Add(b);
        ListaAlumnos.Add(c);
        ListaAlumnos.Add(d);
    }

    public void matricularAlumno(Alumno a) {
        ListaAlumnos.Add(a);
    }

    public void mostrarAlumnos()
    {
        foreach (var alumno in ListaAlumnos)
        {
            Console.WriteLine("Nombre: " + alumno.Nombre + ", edad: " + alumno.obtenerEdad());
        }
    }
}