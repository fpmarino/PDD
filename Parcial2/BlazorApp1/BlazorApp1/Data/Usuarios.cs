
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorApp1.Data
{

   // [Table("Usuario")] 
    public class Usuarios
    {
 
        public int Id { get; set; }

      
        public String Nombre { get; set; }
   

        public String Clave { get; set; }



        public Usuarios() { } 
        public Usuarios(int id, string nombre, string clave)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Clave = clave;
        }



    }
}
