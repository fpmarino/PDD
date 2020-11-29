namespace ClassLibrary1.Entidades
{
    public class Usuarios
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
       
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
