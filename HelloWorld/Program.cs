using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje;
            Console.WriteLine("Proporciona un mensaje por favor");
            mensaje = Console.ReadLine();
            Console.WriteLine("Tu mensaje fue " + mensaje);
            Console.ReadKey();
        }
    }
}