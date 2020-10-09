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


        public Tareas() { }

        public Tareas(int id, string titulo, string vencimiento, int estimacion, Recursos responsable, bool estado)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Vencimiento = vencimiento;
            this.Estimacion = estimacion;
            this.Responsable = responsable;
            this.Estado = estado;
        }
    }
}
