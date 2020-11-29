using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entidades
{
    public class Detalles
    {
      
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Tiempo { get; set; }

        public int IdRecurso { get; set; }
        public Recursos Recur { get; set; }

        public int IdTarea { get; set; }
        public Tareas Tarea { get; set; }

        public Detalles() { }


        public Detalles(int Id, string fecha, string tiempo, int IdRecurso, Recursos recurso, int IdTarea, Tareas tarea)
        {
            this.Id = Id;
            this.Fecha = fecha;
            this.Tiempo = tiempo;
            this.IdRecurso = IdRecurso;
            this.Recur = recurso;
            this.IdTarea = IdTarea;
            this.Tarea = tarea;
        }

    }
}
