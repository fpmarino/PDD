using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareasService
    {
        public List<Tareas> getTareas()
        {
            var ctx = new DataContext();
            var lista = ctx.Tarea.ToList();
            return lista;

        }

        private DataContext context;

        public TareasService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Tareas> Get(int id)
        {
            return await context.Tarea.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Tareas>> GetAll()
        {
            return await context.Tarea.ToListAsync();
        }

        public async Task<Tareas> Save(Tareas value)
        {
            if (value.Id == 0)
            {
                await context.Tarea.AddAsync(value);
            }
            else
            {
                context.Tarea.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Tarea.Where(i => i.Id == id).SingleAsync();
            context.Tarea.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }




    }
}
