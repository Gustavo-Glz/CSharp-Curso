using System;

namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            string userData;
            double radius;
            double circleArea;
            Console.WriteLine("Proporciona el radio de tu circulo");
            userData = Console.ReadLine();

            if (double.TryParse(userData, out radius))
            {
                circleArea = PI * Math.Pow(radius, 2);
                Console.WriteLine($"El area del circulo es: {circleArea}");
            }
            else
            {
                Console.WriteLine("El valor proporcionado es incorrecto");
            }
            Console.ReadKey();
        }
    }
}