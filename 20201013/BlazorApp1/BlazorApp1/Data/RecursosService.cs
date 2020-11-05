using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursosService
    {
        public List<Recursos> getRecursos()
        {
            var ctx = new DataContext();
            var lista = ctx.Recurso.ToList();
            return lista;

        }

        private DataContext context;

        public RecursosService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Recursos> Get(int id)
        {
            return await context.Recurso.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Recursos>> GetAll()
        {
            return await context.Recurso.Include(i => i.Usuario).ToListAsync();
        }

        public async Task<Recursos> Save(Recursos value)
        {
            if (value.Id == 0)
            {
                await context.Recurso.AddAsync(value);
            }
            else
            {
                context.Recurso.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Recurso.Where(i => i.Id == id).SingleAsync();
            context.Recurso.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            return await context.Usuario.ToListAsync();
        }

    }
}
