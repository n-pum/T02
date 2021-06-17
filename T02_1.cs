using System;

namespace T02
{
    class T02_1
    {
        static void Main(string[] args)
        {
            // VARIABLES
            int n1 = 5;
            int n2 = 6;
            double n3 = 2.57;
            double suma;

            // OPERACIÓN Y MOSTRAR
            suma = n1 + n3;
            Console.WriteLine(suma);

            // INTRODUCIR NÚMERO
            Console.Write("Introduce un número: ");
            string valor1 = Console.ReadLine();
            Console.WriteLine("El número introducido es: " + valor1);

            int valorint = Convert.ToInt32(valor1);

            // EXIT \\
            Console.Write("Exit...");
            Console.ReadKey(); // Detiene la ejecución
        }
    }
}
