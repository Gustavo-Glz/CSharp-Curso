using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Number[1] = {numbers[1]}");

            string[] fruits = ["Mango", "Platano", "Manzana"];
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"La primera fruta es: {fruits[0]}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Las frutas que tenemos");
            Console.WriteLine($"El tamaño del array de frutas es: {fruits.Length}");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            int[][] numbersOfNumbers = [[1], [1, 2, 3]];
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Arrays dentro de otros arrays");

            foreach (int[] item in numbersOfNumbers)
            {
                foreach (int number in item)
                {
                    Console.WriteLine($"{number}");
                }
            }

            //Arreglo de 2 dimensiones
            int[,] studentScores = new int[2, 2];
            studentScores[0, 0] = 10;
            studentScores[0, 1] = 8;
            studentScores[1, 0] = 9;
            studentScores[1, 1] = 7;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"El estudiante 1 del grup 1 tiene una calificacion de: {studentScores[0, 0]}");

            Console.ReadKey();
        }
    }
}
