using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//cuando el nombre de la primary key que tengo en la tabla no respeta la convencion de entityframework agrego
//data annotations y [Key]

namespace ConsoleApp1
{
    class Usuario
    {
        //[Key] public int UsuarioPK { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(10)]
       
        public string Nombre { get; set; }
        [Required]
        [Column("Password", TypeName = "char(20)")]
        public string Clave { get; set; }
    }
}
