using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class AppContext: DbContext
    {
        public DbSet<Actividad> Actividades { get; set; }
    }
}
