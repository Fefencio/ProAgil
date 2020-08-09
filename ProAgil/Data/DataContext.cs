using Microsoft.EntityFrameworkCore;
using ProAgil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
    }
}
