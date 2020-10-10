using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            InsertarDetalles();
            InsertarTareas();
            Consultar();
            Actualizacion();
            Borrado();
        }

        static void Borrado()
        {
            var ctx = new TareasDbContext();
            var tarea = ctx.Tarea.Where(i => i.Id == 1).Single();
            ctx.Tarea.Remove(tarea);
            ctx.SaveChanges();
        }

        static void Actualizacion()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Tarea.Where(i => i.Id == 1).ToList();
            lista[0].Titulo = "Tarea 1";
            ctx.SaveChanges();
        }
        static void Consultar()
        {
            var ctx = new TareasDbContext();

            var lista1 = ctx.Usuario.ToList();
            foreach (var item in lista1)
            {
                Console.WriteLine($"Nombre: {item.Nombre}");
            }           
            
            var lista2 = ctx.Tarea.ToList();
            foreach (var item in lista2)
            {
                Console.WriteLine($"Titulo: {item.Titulo}");
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

        static void InsertarTareas()
        {
            var ctx = new TareasDbContext();

            ctx.Tarea.Add(new Tareas
            {
                Id = 1,
                Titulo = "Tarea 1",
                Vencimiento = "55 dias",
                Estimacion = 50,
                IdRecursos = 4,
                Estado = true

            });

            ctx.Tarea.Add(new Tareas
            {
                Id = 2,
                Titulo = "Tarea 2",
                Vencimiento = "34 dias",
                Estimacion = 40,
                IdRecursos = 2,
                Estado = false

            });


            ctx.SaveChanges();

        }
    }

}
