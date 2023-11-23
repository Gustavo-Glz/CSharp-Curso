using System;
using System.Collections;

namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int counter;
            Stack greetingStack = new Stack();
            greetingStack.Push("Hola");
            greetingStack.Push("Buenos");
            greetingStack.Push("Dias");
            counter = greetingStack.Count;
            Console.WriteLine($"Hay {counter} elementos en la pila");

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }
            Console.ReadKey();


            //Usando Peek: Muestra el valor de la pila sin extraer
            greetingStack.Push("Hola");
            greetingStack.Push("Buenos");
            greetingStack.Push("Dias");
            counter = greetingStack.Count;
            Console.WriteLine($"Hay {counter} elementos en la pila");

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Peek();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La siguiente palabra de la pila es: {word}");
                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }
            Console.ReadKey();

            //Usando Contain y Clear
            greetingStack.Push("Hola");
            greetingStack.Push("Buenos");
            greetingStack.Push("Dias");

            if (greetingStack.Contains("Dias")) greetingStack.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La pila ahora contiene {greetingStack.Count} elementos despues de ejecutar el metodo Clear()");
            Console.ReadKey();

            //Colas
            Queue greetingQueue = new Queue();
            greetingQueue.Enqueue("Hola");
            greetingQueue.Enqueue("Buenos");
            greetingQueue.Enqueue("Dias");

            counter = greetingQueue.Count;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Hay {counter} elementos en la cola");

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingQueue.Peek();
                Console.WriteLine($"El siguiente elemento de la cola es: {word}");
                word = (string)greetingQueue.Dequeue();
                Console.WriteLine($"Dequeue: {word}");
            }

            Console.ReadKey();
        }
    }
}
