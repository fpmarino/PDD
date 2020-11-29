using BlazorApp1.Pages;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1.Data
{
    public class Detalles
    {
      
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Tiempo { get; set; }

        public int RecursoId { get; set; }
        public Recursos Recurso { get; set; }

        public int Tareaid { get; set; }
        public Tareas Tarea { get; set; }

        public Detalles() { }   


        public Detalles(int id, string fecha, string tiempo, int IdRecurso, Recursos recurso, int IdTarea, Tareas tarea)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Tiempo = tiempo;
            this.RecursoId = IdRecurso;
            this.Recurso = recurso;
            this.Tareaid = IdTarea;
            this.Tarea = tarea;
        }
    }
}
