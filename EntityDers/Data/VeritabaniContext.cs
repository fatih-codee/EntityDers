using EntityDers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityDers.Data
{
    public class VeritabaniContext :DbContext
    {
        public DbSet< Musteri> Musteriler { get; set; }

        public VeritabaniContext(DbContextOptions<VeritabaniContext> options) : base(options)
        {

        }
    }
}
