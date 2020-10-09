using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Required]
        public string Clave { get; set; }

        public Usuarios() { }

        public Usuarios (int id, string nombre, string clave)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Clave = Clave;
        }
    }
}
