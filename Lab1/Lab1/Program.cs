using System;

namespace Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var p1 = new Persona("Bob" , "Kunga");
            //p1.Nombre = "Bob";
            //p1.Apellido = "Kunga";
            //Console.WriteLine(p1.Nombre);
            //Console.WriteLine(p1.Apellido);

            

            Console.WriteLine(p1.Lanzar());
            Console.WriteLine(p1.Choice);
        }
    }
}
