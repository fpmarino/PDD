using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1.Entidades
{
    public class Tareas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Vencimiento { get; set; }
        public string Estimacion { get; set; }
        public Recursos Responsable { get; set; }
        public int IdRecursos { get; set; }
        public bool Estado { get; set; }

        public Tareas() { }

    }
}
