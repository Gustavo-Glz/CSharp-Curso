using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            //Eliminar un elemento existente en la lista
            if (numbers.Contains(1))
            {
                numbers.Remove(1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Se ha eliminado el valor 1 en la lista");
            }

            if (!numbers.Contains(1))
            {
                numbers.Insert(0, 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Se ha agregado el valor 1 en la lista");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            ShowListContain(numbers);


            List<int> numbers2 = [10, 20, 30, 40, 50];
            Console.ForegroundColor = ConsoleColor.Magenta;
            ShowListContain(numbers2);
            numbers2.InsertRange(0, numbers);
            ShowListContain(numbers2);
            Console.ReadKey();
        }

        private static void ShowListContain(List<int> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
