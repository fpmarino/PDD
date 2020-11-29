using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Detalles
    {
        [Key]
        public int id { get; set; }
        public string Fecha { get; set; }
        public string Tiempo { get; set; }

        public int IdRecurso { get; set; }
        public Recursos Recur { get; set; }

        public int IdTarea { get; set; }
        public Tareas Tarea { get; set; }

        public Detalles() { }


        public Detalles(int id, string fecha, string tiempo, int IdRecurso, Recursos recurso, int IdTarea, Tareas tarea)
        {
            this.id = id;
            this.Fecha = fecha;
            this.Tiempo = tiempo;
            this.IdRecurso = IdRecurso;
            this.Recur = recurso;
            this.IdTarea = IdTarea;
            this.Tarea = tarea;
        }


    }
}
