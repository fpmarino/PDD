
using Microsoft.EntityFrameworkCore;
using Refit;
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
          
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetDetalles(id);
        }

        public async Task<List<Detalles>> GetAll()
        {
            

            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllDetalle();

        }

        public async Task<Detalles> Save(Detalles value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GuardarDetalles(value);
        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Detalle.Where(i => i.id == id).SingleAsync();
            context.Detalle.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }


        public async Task<List<Recursos>> GetRecursos()
        {
            // return await context.Recursos.ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllRecurso();


        }

        public async Task<List<Tareas>> GetTareas()
        {
            //  return await context.Tareas.ToListAsync();
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllTarea();
        }


    }

}