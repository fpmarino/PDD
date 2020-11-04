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
            var ctx = new DbContext();
            var lista = ctx.Tareas.ToList();
            return lista;

        }

        private DbContext context;

        public TareasService(DbContext _context)
        {
            context = _context;
        }

        public async Task<Tareas> Get(int id)
        {
            return await context.Tareas.Where(i => i.id == id).SingleAsync();
        }

        public async Task<List<Tareas>> GetAll()
        {
            return await context.Tareas.ToListAsync();
        }

        public async Task<Tareas> Save(Tareas value)
        {
            if (value.id == 0)
            {
                await context.Tareas.AddAsync(value);
            }
            else
            {
                context.Tareas.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Tareas.Where(i => i.id == id).SingleAsync();
            context.Tareas.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }




    }
}
