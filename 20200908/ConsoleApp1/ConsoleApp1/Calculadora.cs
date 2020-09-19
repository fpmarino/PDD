using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp1
{
    public class Calculadora
    {
        private int numero1;
        public int Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                numero1 = value; 
            }
        }

        public int Numero2 { get; set; }

        public Calculadora()
        {

        }

        public Calculadora(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public int Metodo()
        {
            if (Numero1 == Numero2)
            {
                return 0;
            }
            return 1;
        }
    }
}
