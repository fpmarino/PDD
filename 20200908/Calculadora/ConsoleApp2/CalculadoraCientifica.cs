﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class CalculadoraCientifica : Calculadora
    {
        public double Potencia(int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }
    }
}
