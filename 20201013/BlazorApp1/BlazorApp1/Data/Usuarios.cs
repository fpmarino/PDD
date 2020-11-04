using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorApp1.Data
{

    [Table("Usuario")] // cambia el nombre de mi tabla
    public class Usuarios
    {
        [Key]
        public int id { get; set; }
        public String nombre { get; set; }
        [Required] 
        public String clave { get; set; }



        public Usuarios() { } 
        public Usuarios(int id, string nombre, string clave)
        {
            this.id = id;
            this.nombre = nombre;
            this.clave = clave;
        }



    }
}