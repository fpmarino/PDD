using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Recursos
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public Usuarios Usuario { get; set; }

        public int IdUsuario { get; set; }

        public Recursos() { }

        public Recursos(int id, string nombre, Usuarios usuario)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Usuario = usuario;
        }



    }
}
