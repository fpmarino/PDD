
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
            return _context.Recursos.Include(i => i.User).ToList();
        }

        [HttpGet("{id}")]
        public Recursos Get(int id)
        {
            return _context.Recursos.Where(i => i.id == id).Single();
        }



        [HttpPost]

        public Recursos Post(Recursos valor)
        {
            if (valor.Id == 0)
            {
                _context.Recursos.Add(valor);
            }
            else
            {
                _context.Recursos.Attach(valor);
                _context.Recursos.Update(valor);
            }

            _context.SaveChanges();
            return valor;
        }



    }
}