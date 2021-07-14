using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using felipe_santos_volvoapp.Models;

namespace felipe_santos_volvoapp.Data
{
    public class felipe_santos_volvoappContext : DbContext
    {
        public felipe_santos_volvoappContext (DbContextOptions<felipe_santos_volvoappContext> options)
            : base(options)
        {
        }

        public DbSet<felipe_santos_volvoapp.Models.Caminhao> Caminhao { get; set; }
    }
}
