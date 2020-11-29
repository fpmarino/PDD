
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
        public int Id { get; set; }
        public String Nombre { get; set; }

        public int UsuarioId { get; set; }
        public Usuarios Usuario { get; set; }


        public Recursos() { } 


        public Recursos(int id, string nombre, int IdUsuario, Usuarios usuario)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.UsuarioId = IdUsuario;
            this.Usuario = usuario;
        }




    }
}
