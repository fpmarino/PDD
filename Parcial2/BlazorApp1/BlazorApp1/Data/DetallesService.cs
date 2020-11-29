using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetallesService
    {

        public List<Detalles> GetDetalles()
        {
            var ctx = new dbContext();
            var lista = ctx.Detalles.ToList();
            return lista;

        }


        private readonly dbContext context;

        public DetallesService(dbContext _context)
        {
            context = _context;
        }

        public async Task<Detalles> Get(int id)
        {
            return await context.Detalles.Where(i => i.Id == id).SingleAsync();
        }

       // public async Task<List<Detalles>> GetAll()
        //{
            // return await context.Detalles.ToListAsync();

           // var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
          //  return await remoteService.GetAllDetalle();

        //}

        public async Task<Detalles> Save(Detalles value)
        {
            if (value.Id == 0)
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

            var entidad = await context.Detalles.Where(i => i.Id == id).SingleAsync();
            context.Detalles.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }


        public async Task<List<Recursos>> GetRecursos()
        {
            return await context.Recursos.ToListAsync();
        }

        public async Task<List<Tareas>> GetTareas()
        {
            return await context.Tareas.ToListAsync();
        }

    }
}
