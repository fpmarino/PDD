using System;
using ClassLibrary1; /*opcion2*/
using ConsoleApp1.Componentes;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora();
            calculadora.Numero1 = 10;
            Console.WriteLine(calculadora.Numero1);

            calculadora.Numero2 = 32;
            Console.WriteLine(calculadora.Numero2);

                



            Class1 clase = new Class1();
            Grilla grilla;
            ClassLibrary1.DAL.db db;


        }
    }
}
