using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Actualizacion2();
            Consultar();
            
        }

        static void Borrado()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuario.Where(i => i.UsuarioPK == 1).Single();
            ctx.Usuario.Remove(usuario);
            ctx.SaveChanges();
        }
        static void Actualizacion2()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuario.Where(i => i.UsuarioPK == 1).Single(); //le dice al entityframework que devuelva un unico registro

            usuario.Nombre = "Facu";

            var usuario2 = ctx.Usuario.Where(i => i.UsuarioPK == 3).FirstOrDefault(); //trae el primero que aparezca y si no hay ninguno devuelve null
            if(usuario2 != null)
            {
                usuario2.Nombre = "Prueba";
            }

            var usuario3 = ctx.Usuario.Where(i => i.Nombre == "Gabriel" && i.UsuarioPK < 4).FirstOrDefault();
            if(usuario3!= null)
            {
                usuario3.Nombre = "Francsico";
            }
            ctx.SaveChanges();
        }

        static void Actualizacion()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuario.Where(i => i.UsuarioPK == 1).ToList();
            lista[0].Nombre = "Facu";
            ctx.SaveChanges();
        }
        static void Consultar()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuario.ToList();
            foreach(var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre}");
            }

        }

        static void Insertar()
        {
            var ctx = new TareasDbContext();

            ctx.Usuario.Add(new Usuario
            {
                UsuarioPK = 1,
                Nombre = "Florencia",
                Clave = "1234"
            });
            ctx.SaveChanges();

        }
    }
}
