using BlazorApp1.Pages;
using Microsoft.EntityFrameworkCore;
using Refit;
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
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetRecurso(id);
        }

        public async Task<List<Recursos>> GetAll()
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllRecurso();

        }

        public async Task<Recursos> Save(Recursos value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GuardarRecursos(value);

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

            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllUsuario();

        }




    }
}
