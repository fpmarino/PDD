using BlazorApp1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1.Data
{
    public class Recursos
    {
        [Key]
        public int id { get; set; }
        public String nombre { get; set; }

        public int IdUsuario { get; set; }
        public Usuarios User { get; set; }


        public Recursos() { }   //constructor implicito 


        public Recursos(int id, string nombre, int IdUsuario, Usuarios usuario)
        {
            this.id = id;
            this.nombre = nombre;
            this.IdUsuario = IdUsuario;
            this.User = usuario;
        }




    }
}
