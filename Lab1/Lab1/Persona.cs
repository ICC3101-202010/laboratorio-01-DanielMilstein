using System;

namespace Lab1
{
    public class Persona
    {
        public string Nombre;
        public string Apellido;
        public int Choice;

        public Persona()
        {

        }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public Persona(string nombre , string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public int Lanzar()
        {
            Random rand = new Random();
            Choice = rand.Next(0, 3);
            return Choice;

        }
    }

}
