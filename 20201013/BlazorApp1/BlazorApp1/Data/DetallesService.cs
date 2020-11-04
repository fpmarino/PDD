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
            var ctx = new DbContext();
            var lista = ctx.Detalles.ToList();
            return lista;

        }


        private DbContext context;

        public DetallesService(DbContext _context)
        {
            context = _context;
        }

        public async Task<Detalles> Get(int id)
        {
            return await context.Detalles.Where(i => i.id == id).SingleAsync();
        }

        public async Task<List<Detalles>> GetAll()
        {
            return await context.Detalles.ToListAsync();
        }

        public async Task<Detalles> Save(Detalles value)
        {
            if (value.id == 0)
            {
                await context.Detalles.AddAsync(value);
            }
            else
            {
                context.Detalles.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Detalles.Where(i => i.id == id).SingleAsync();
            context.Detalles.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }



    }

}
