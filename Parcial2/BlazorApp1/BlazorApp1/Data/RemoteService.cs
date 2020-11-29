
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IRemoteService
    {

        [Get("/Tareas")]
        Task<List<Tareas>> GetAllTarea();

        [Get("/Usuarios")]
        Task<List<Usuarios>> GetAllUsuario();

        [Get("/Recursos")]
        Task<List<Recursos>> GetAllRecurso();

        [Get("/Detalles")]
        Task<List<Detalles>> GetAllDetalle();



    }
}