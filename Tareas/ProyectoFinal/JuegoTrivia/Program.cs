using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 _____ _____ _____  _   _   ___________ _____ _   _ _____  ___      +
|_   _|  ___/  __ \| | | | |_   _| ___ \_   _| | | |_   _|/ _ \     +
  | | | |__ | /  \/| |_| |   | | | |_/ / | | | | | | | | / /_\ \    +
  | | |  __|| |    |  _  |   | | |    /  | | | | | | | | |  _  |    +
  | | | |___| \__/\| | | |   | | | |\ \ _| |_\ \_/ /_| |_| | | |    +
  \_/ \____/ \____/\_| |_/   \_/ \_| \_|\___/ \___/ \___/\_| |_/    +
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++                                                                
                                                                
";
            Console.WriteLine(text);
            

            //Obteniendo nombre de Usuario
            Console.WriteLine("Hola usuario! Cual es tu Nombre:?");
            string nombre = Console.ReadLine(); 
            Console.WriteLine("");

            //Bienvenida al juego,y brindando las reglas del juego.
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Bienvenido, " + nombre +"  ! Me gustaria jugar un juego de trivia contigo.        +");
            Console.WriteLine("Te mostrare una serie de preguntas para que escribas sus repuestas.             +");
            Console.WriteLine("Luego tratare de adivinar si tu respuesta es correcta o no.                     +");
            Console.WriteLine("Luego de 5 preguntas el juego finalizara y mostrara tu puntaje. Buena suerte!  +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            
            Console.WriteLine("");

            //Definiendo variables para uso 
            //durante el juego
            int tiempo = 5;
            int marcador = 0;
            int correcto = 0;
            int incorrecto = 0;

            //Configurando un ciclo al azar
            //para generar una pregunta del archivo .txt
            // y obtener respuesta de usuarios 
            //y generar nuevas preguntas.
            while (tiempo > 0)
            {
                //Generador aleatorio de preguntas
                Random random = new Random();
                int randomNum = random.Next(1,25);
                var Trivia = GetTriviaList()[randomNum];

                //Dando al usuario la pregunta
                Console.WriteLine("Pregunta: ¿"+Trivia.Pregunta+"?");
                
                //Recibiendo respuesta del usuario
                Console.Write("Respuesta: ");
                
                //configurando respuesta de usuario para que sea minuscula.
                string input = Console.ReadLine().ToLower();

                //configurando la comparacion de la repuesta de usuario 
                // to the actual answer of the question
                if (input == Trivia.Respuesta.ToLower())
                {
                    //agrega 1 al contador de respuestas correctas
                    correcto++;

                    //Agrega 100 puntos al marcador del usuario
                    marcador += 100;

                    //Resta 1 al numero de preguntas 
                    // Que el usuario tiene hasta el final del juego
                    tiempo--;

                    //Muestra que el usuario tiene una respuesta correcta
                    Console.WriteLine("Tu respuesta es correcta! Buen Trabajo!!!");
                    Console.WriteLine("________________________________________________________________________________");
                    Console.WriteLine("");
                }
                else
                {
                    //Agrega 1 al contador de respuestas incorrectas
                    incorrecto++;

                    //Resta 100 puntos al marcador del usuario
                    marcador +=-100;

                    //Resta 1 al numero de preguntas 
                    // Que el usuario tiene hasta el final del juego
                    tiempo--;

                    //Muestra que el usuario tiene una respuesta correcta 
                    Console.WriteLine("Tu respuesta esta incorrecta. La respuesta correcta es: " + Trivia.Respuesta.ToUpper());
                    Console.WriteLine("________________________________________________________________________________");
                    Console.WriteLine("");
                }
            }
            //Mestra el puntaje final del usuario 
            // repuestas correctas en caso exista. 
            // repuestas incorrectas en caso existan.
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");    
            Console.WriteLine("Jugador: " + nombre + "  Puntaje: " + marcador);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            
            Console.WriteLine();
            Console.WriteLine("Buen Trabajo! Usted tiene " + correcto + " respuestas correctas y " + incorrecto + " respuestas incorrectas. Mejor suerte para la proxima!!!");
            Console.WriteLine();

            
            Console.ReadKey();
        }

        //Esta función obtiene la lista completa de preguntas de trivia del documento Trivia.txt
        static List<Trivia> GetTriviaList()
        {
            //Obtiene el contenido desde el archivo. Remueve el caracter especial char "\r". Divide cada uno en una linea. Para convertirlo en una lista.
            List<string> contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();

           
            //Cada elemento de la lista "contenido" ahora es una línea del documento Trivia.txt.
            //hace una nueva lista para retornar todas las preguntas de la trivia.
            List<Trivia> returnList = new List<Trivia>();

            
            // revisa cada línea en el contenido del archivo de trivia y crea un objeto de trivia.
            foreach (string pregunta in contents)
            {
                Trivia a = new Trivia(pregunta);
                returnList.Add(a);
            }

            //Retorna la lista completa de preguntas.
            return returnList;

        }
    }
}

