using System;
public class Persona    //Persona es la clase padre de Cliente y Vendedor
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string  Telefono { get; set; }
    

    public void EnviarNotificacion()
    {
        Console.WriteLine("Notificacion enviada a: " + Nombre);
    }
    
}