using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ctx = new TareasDbContext();

            ctx.Set<Usuario>().Add(new Usuario
            {
                UsuarioPK = 1,
                Nombre = "Florencia",
                Clave = "1234"
            });
            ctx.SaveChanges();
        }
    }
}
