using Microsoft.EntityFrameworkCore;
using Refit;
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
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetTarea(id);
        }




        public async Task<List<Tareas>> GetAll()
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllTarea();

        }

        public async Task<Tareas> Save(Tareas value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GuardarTareas(value);


        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Tarea.Where(i => i.Id == id).SingleAsync();
            context.Tarea.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }

        public async Task<List<Recursos>> GetRecursos()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllRecurso();

        }




    }
}