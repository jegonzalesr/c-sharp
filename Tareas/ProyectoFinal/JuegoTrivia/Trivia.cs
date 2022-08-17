using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTrivia
{
    class Trivia
    {
         
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        
        
        //configurando el constructor para el objeto
        public Trivia(string splitString)
        {
            //Aqui se crea el contenedor para las preguntas de Trivia 
            List<string> PyR = new List<string>();
            
            //Dividiendo las preguntas entre
            //preguntas y respuestas despues de *.
            PyR = splitString.Split('*').ToList();

            //Configuracion para que el juego para que reconozca 
            //que las preguntas son todo lo que esta antes de *
            //y que las respuestas son todo lo que esta despues de *.
            this.Pregunta = PyR[0];
            this.Respuesta = PyR[1];
        }
    }
}
