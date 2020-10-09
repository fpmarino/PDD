using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ctx = new TareasDbContext();
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
            if (usuario2 != null)
            {
                usuario2.Nombre = "Prueba";
            }

            var usuario3 = ctx.Usuario.Where(i => i.Nombre == "Gabriel" && i.UsuarioPK < 4).FirstOrDefault();
            if (usuario3 != null)
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
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre}");
            }

        }

        static void InsertarDetalles()
        {
            var ctx = new TareasDbContext();

            ctx.Detalle.Add(new Detalles
            {
                Id = 2,
                Fecha = "15/03/1994",
                Tiempo = "55 dias",
                IdRecurso = 4,
                IdTareas = 4

            });

            ctx.Detalle.Add(new Detalles
            {
                Id = 4,
                Fecha = "16/03/2005",
                Tiempo = "32 dias",
                IdRecurso = 3,
                IdTareas = 2

            });

            ctx.Detalle.Add(new Detalles
            {
                Id = 3,
                Fecha = "16/07/2003",
                Tiempo = "68 dias",
                IdRecurso = 3,
                IdTareas = 1

            });

            ctx.Detalle.Add(new Detalles
            {
                Id = 1,
                Fecha = "15/11/2015",
                Tiempo = "100 dias",
                IdRecurso = 1,
                IdTareas = 2

            });
            ctx.SaveChanges();

        }
    }

}
