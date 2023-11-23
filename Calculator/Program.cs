using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int operation;
            int firstNum;
            int secondNum;

            Console.WriteLine("Bienvenido a tu calculadora");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Salir");
            operation = GetIntegerDataFromUser("¿Que operacion desea realizar?");

            switch (operation)
            {
                case 1:
                    firstNum = GetIntegerDataFromUser("Proporciona el primer numero");
                    secondNum = GetIntegerDataFromUser("Proporciona el segundo numero");
                    Console.WriteLine($"El resultado de la suma de {firstNum} + {secondNum} es: {firstNum + secondNum}");
                    break;

                case 2:
                    firstNum = GetIntegerDataFromUser("Proporciona el primer numero");
                    secondNum = GetIntegerDataFromUser("Proporciona el segundo numero");
                    Console.WriteLine($"El resultado de la resta de {firstNum} - {secondNum} es: {firstNum - secondNum}");
                    break;
                case 3:
                    return;

                default:
                    Console.WriteLine("La opcion seleccionada no existe");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }

        private static int GetIntegerDataFromUser(string message)
        {
            string userData;
            int data = 0;
            bool isDataValid = false;

            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                if (int.TryParse(userData, out data))
                {
                    isDataValid = true;
                }
                else
                {
                    Console.WriteLine("Dato proporcinado no valido, vuelve a intentarlo");
                }
            }
            return data;
        }
    }
}
