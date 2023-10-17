using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ispas_Adelina_Lab2.Models;

namespace Ispas_Adelina_Lab2.Data
{
    public class Ispas_Adelina_Lab2Context : DbContext
    {
        public Ispas_Adelina_Lab2Context (DbContextOptions<Ispas_Adelina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ispas_Adelina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ispas_Adelina_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
