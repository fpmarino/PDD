using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetallesService
    {
        public List<Detalles> getDetalles()
        {
            var ctx = new DataContext();
            var lista = ctx.Detalle.ToList();
            return lista;

        }


        private DataContext context;

        public DetallesService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Detalles> Get(int id)
        {
            return await context.Detalle.Where(i => i.id == id).SingleAsync();
        }

        public async Task<List<Detalles>> GetAll()
        {
            return await context.Detalle.ToListAsync();
        }

        public async Task<Detalles> Save(Detalles value)
        {
            if (value.id == 0)
            {
                await context.Detalle.AddAsync(value);
            }
            else
            {
                context.Detalle.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Detalle.Where(i => i.id == id).SingleAsync();
            context.Detalle.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }
    }
}
