using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class CalculadoraBase /*no puedo crear un objeto me sirve para poderla heredar en otra*/
    {
        public int Restar(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
    }
    /*sealed clase sellada lo pongo si quier que no se pueda heredar de una clase*/
}
