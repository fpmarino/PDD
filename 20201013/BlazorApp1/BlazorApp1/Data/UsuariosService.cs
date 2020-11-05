using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuariosService
    {
        public List<Usuarios> getUsuarios()
        {
            var ctx = new DataContext();
            var lista = ctx.Usuario.ToList();

            return lista;

        }

        private DataContext context;

        public UsuariosService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Usuarios> Get(int id)
        {
            return await context.Usuario.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Usuarios>> GetAll()
        {
            return await context.Usuario.ToListAsync();
        }

        public async Task<Usuarios> Save(Usuarios value)
        {
            if (value.Id == 0)
            {
                await context.Usuario.AddAsync(value);
            }
            else
            {
                context.Usuario.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Usuario.Where(i => i.Id == id).SingleAsync();
            context.Usuario.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }

    }
}
