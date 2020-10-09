using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TipoTarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoId { get; set; }
        public TipoTarea Tipo { get; set; }
        
    }
}
