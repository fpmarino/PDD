﻿using BlazorApp1.Pages;
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
        public List<Recursos> GetRecursos()
        {
            var ctx = new dbContext();
            var lista = ctx.Recursos.ToList();
            return lista;

        }

        private readonly dbContext context;

        public RecursosService(dbContext _context)
        {
            context = _context;
        }

        public async Task<Recursos> Get(int id)
        {
            return await context.Recursos.Where(i => i.Id == id).SingleAsync();
        }

  /*      public async Task<List<Recursos>> GetAll()
        {
            // return await context.Recursos.Include(i=>i.User).ToListAsync();
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllRecurso();

        }
  */

        public async Task<Recursos> Save(Recursos value)
        {
            if (value.Id == 0)
            {
                await context.Recursos.AddAsync(value);
            }
            else
            {
                context.Recursos.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {

            var entidad = await context.Recursos.Where(i => i.Id == id).SingleAsync();
            context.Recursos.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            return await context.Usuarios.ToListAsync();
        }




    }
}