using ClassLibrary1.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class TareasController : ControllerBase
    {

        private readonly Data.DataContext _context;


        public TareasController(Data.DataContext context)
        {
            _context = context;
        }


        [HttpGet]

        public List<Tareas> Get()
        {
            return _context.Tareas.Include(i => i.Responsable).ToList();
        }



    }
}