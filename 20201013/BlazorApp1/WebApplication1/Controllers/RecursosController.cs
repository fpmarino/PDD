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

    public class RecursosController : ControllerBase
    {


        private readonly Data.DataContext _context;


        public RecursosController(Data.DataContext context)
        {
            _context = context;
        }


        [HttpGet]

        public List<Recursos> Get()
        {
            return _context.Recursos.Include(i => i.Usuario).ToList();
        }



    }
}
