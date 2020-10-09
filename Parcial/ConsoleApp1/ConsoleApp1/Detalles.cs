using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Detalle
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Tiempo { get; set; }
        public int IdRecurso { get; set; }
        public Recursos Recurso { get; set; }
        public int IdTareas { get; set; }
        public Tareas Tareas { get; set; }
    }
}
