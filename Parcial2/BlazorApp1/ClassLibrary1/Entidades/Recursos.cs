
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Entidades
{
    public class Recursos
    {
      
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
