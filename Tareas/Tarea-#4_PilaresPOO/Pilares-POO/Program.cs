using System;
using System.Collections.Generic;

namespace PilaresPOO
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.reino = "Mamifero";
            animal.reino = "Aves";
            animal.reino = "Peces";
            animal.clasificacion = "Vertebrado";
            animal.clasificacion = "Invertebrado";
            animal.respiracion = "Pulmonar";
            animal.respiracion = "Branquial";
            animal.alimentacion = "Carnivoro";
            animal.alimentacion = "Herbivoro";
            animal.alimentacion = "Omnivoro";
            animal.reproduccion = "Viviparo";
            animal.reproduccion = "Oviparo";

            Console.WriteLine("Ingrese el nombre del animal: ");
            animal.nombre = Console.ReadLine();

            Console.WriteLine("El animal es un " + animal.reino + " y es un " + animal.clasificacion + " que respira " + animal.respiracion + " y se alimenta de " + animal.alimentacion + " y su reproduccion es " + animal.reproduccion + " y su nombre es " + animal.nombre);
            Console.ReadKey();

            }

        }

}    
