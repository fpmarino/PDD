using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class UsuariosService
    {
        private DataContext context;

        public List<Usuarios> getUsuarios()
        {
            var ctx = new DataContext();
            var lista = ctx.Usuario.ToList();

            return lista;

        }



        public UsuariosService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Usuarios> Get(int id)
        {
          
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetUsuario(id);
        }





        public async Task<List<Usuarios>> GetAll()
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllUsuario();

        }

        public async Task<Usuarios> GuardarUsuario(Usuarios value)
        {
            
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GuardarUsuario(value);

        }


        public List<Usuarios> GetAllUsuario()
        {

            return context.Usuario.ToList();
        }

        public async Task<Usuarios> Save(Usuarios value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44357/api/");
            return await remoteService.GuardarUsuario(value);
           
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