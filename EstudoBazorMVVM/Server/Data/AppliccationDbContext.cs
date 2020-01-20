using EstudoBazorMVVM.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoBazorMVVM.Server.Data
{
    public class AppliccationDbContext : DbContext
    {
        public AppliccationDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
