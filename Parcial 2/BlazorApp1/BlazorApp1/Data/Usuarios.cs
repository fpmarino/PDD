using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Required]
        public string Clave { get; set; }

        public Usuarios() { }

        public Usuarios(int id, string nombre, string clave)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Clave = Clave;
        }
    }
}
