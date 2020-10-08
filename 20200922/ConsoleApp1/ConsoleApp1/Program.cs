﻿using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehiculo miauto = new Auto();
            Auto otroauto = new Auto();
            Vehiculo camion = new Camion();

            miauto.Marca = "Honda";
            miauto.Modelo = "Civic";
            miauto.Motor = new CuatroCilindros();
            if (camion is Auto)
            {
                ((Auto)miauto).Puertas = 5;
            }
        }
    }
}