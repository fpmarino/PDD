using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] nombres = { "Gabriel", "Facundo", "Francisco", "Maria Laura" };
            
            IEnumerable<string> empiezanConF = from nombre in nombres where nombre.StartsWith("F") select nombre;

            IEnumerable<string> empiezanConM = nombres.Where(i => i.StartsWith("M"));
            foreach (var item in empiezanConF)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
