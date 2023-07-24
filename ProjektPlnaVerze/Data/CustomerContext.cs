using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjektPlnaVerze.Models;

    public class CustomerContext : DbContext
    {
        public CustomerContext (DbContextOptions<CustomerContext> options)
            : base(options)
        {
        }

        public DbSet<ProjektPlnaVerze.Models.Customer> Customer { get; set; } = default!;

        public DbSet<ProjektPlnaVerze.Models.Insurance>? Insurance { get; set; }
    }
