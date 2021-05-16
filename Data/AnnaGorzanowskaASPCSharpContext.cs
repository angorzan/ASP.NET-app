using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnnaGorzanowskaASPCSharp.Models;

namespace AnnaGorzanowskaASPCSharp.Data
{
    public class AnnaGorzanowskaASPCSharpContext : DbContext
    {
        public AnnaGorzanowskaASPCSharpContext (DbContextOptions<AnnaGorzanowskaASPCSharpContext> options)
            : base(options)
        {
        }

        public DbSet<AnnaGorzanowskaASPCSharp.Models.Animal> Animal { get; set; }
    }
}
