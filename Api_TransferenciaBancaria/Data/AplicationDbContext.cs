using Api_TransferenciaBancaria.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_TransferenciaBancaria.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Cuenta> Cuenta { get; set; }
        
        public DbSet<Transaccion> Transaccions { get; set; }
    }
}
