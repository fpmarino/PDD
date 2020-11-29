using ClassLibrary1.Entidades;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{


    [Route("api/[controller]")]
    [ApiController]

    public class DetallesController : ControllerBase
    {
        private readonly Data.DataContext _context;


        public DetallesController(Data.DataContext context)
        {
            _context = context;
        }


        [HttpGet]

        public List<Detalles> Get()
        {
            return _context.Detalles.ToList();
        }

        [HttpGet("{id}")]
        public Detalles Get(int id)
        {
            return _context.Detalles.Where(i => i.Id == id).Single();
        }


        [HttpPost]

        public Detalles Post(Detalles valor)
        {
            if (valor.Id == 0)
            {
                _context.Detalles.Add(valor);
            }
            else
            {
                _context.Detalles.Attach(valor);
                _context.Detalles.Update(valor);
            }

            _context.SaveChanges();
            return valor;
        }



    }
}