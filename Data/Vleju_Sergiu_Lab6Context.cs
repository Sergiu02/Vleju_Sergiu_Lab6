using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vleju_Sergiu_Lab6.Models;

namespace Vleju_Sergiu_Lab6.Data
{
    public class Vleju_Sergiu_Lab6Context : DbContext
    {
        public Vleju_Sergiu_Lab6Context (DbContextOptions<Vleju_Sergiu_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Vleju_Sergiu_Lab6.Models.Book> Book { get; set; }
    }
}
