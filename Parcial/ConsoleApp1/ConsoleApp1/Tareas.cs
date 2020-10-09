using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tareas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recursos Responsable { get; set; }
        public int IdRecursos { get; set; }
        public bool Estado { get; set; }
    }
}
