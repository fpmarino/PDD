using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Vehiculo 
    {
        public string Marca { get; set;  }
        public string Modelo { get; set; }
        public Motor Motor { get; set; }

        public abstract void Detener();
        public void Arrancar()
        {
            Console.Write("El vehiculo arranco");
        }
    }
}
