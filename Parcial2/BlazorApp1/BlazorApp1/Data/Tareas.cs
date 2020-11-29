using BlazorApp1.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1.Data
{
    public class Tareas
    {
        
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Vencimiento { get; set; }
        public String Estimacion { get; set; }
        public int ResponsableId { get; set; }
        public Recursos Responsable { get; set; }
        public bool Estado { get; set; }


        public Tareas() { }  

        public Tareas(int id, string titulo, string vencimiento, string estimacion, int IdRecursos, Recursos responsable, bool estado)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Vencimiento = vencimiento;
            this.Estimacion = estimacion;
            this.ResponsableId = IdRecursos;
            this.Responsable = responsable;
            this.Estado = estado;
        }




    }
}
