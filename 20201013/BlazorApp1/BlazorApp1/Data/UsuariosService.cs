using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class UsuariosService
    {
        public List<Usuarios> getUsuarios()
        {
            var ctx = new DbContext();
            var lista = ctx.Usuarios.ToList();

            return lista;

        }

        private DbContext context;

        public UsuariosService(DbContext _context)
        {
            context = _context;
        }

        public async Task<Usuarios> Get(int id)
        {
            return await context.Usuarios.Where(i => i.id == id).SingleAsync();
        }

        public async Task<List<Usuarios>> GetAll()
        {
            return await context.Usuarios.ToListAsync();
        }

        public async Task<Usuarios> Save(Usuarios value)
        {
            if (value.id == 0)
            {
                await context.Usuarios.AddAsync(value);
            }
            else
            {
                context.Usuarios.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Usuarios.Where(i => i.id == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }






    }
}