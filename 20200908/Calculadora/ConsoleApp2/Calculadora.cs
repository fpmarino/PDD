using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Calculadora
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public Calculadora()
        {

        }

        public Calculadora(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }
}
