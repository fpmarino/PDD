using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroElegido = 16;
            int intento = 0;
            int maxintentos = 2;
            while ((numeroElegido != intento)  && (intento <= maxintentos))
            {
                Console.WriteLine("Ingrese un número del 1 al 20. Tenes 4 intentos: ");
                intento = int.Parse(Console.ReadLine());
                if (intento == numeroElegido)
                {
                    Console.WriteLine("Felicitaciones!");
                }
                else
                {
                    Console.WriteLine("Pruebe otra vez");
                }
               
            }
        }
    }   
}

