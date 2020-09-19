using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(5, 7));
            Console.WriteLine(calculadora.Restar(6,2));
            Console.WriteLine(calculadora.Multiplicar(4,5));
            Console.WriteLine(calculadora.Dividir(8,2));
        }
    }
}
