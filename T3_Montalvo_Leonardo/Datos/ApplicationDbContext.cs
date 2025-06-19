using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3_Montalvo_Leonardo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace T3_Montalvo_Leonardo.Datos
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Libro> Libro { get; set; }
    }
}
