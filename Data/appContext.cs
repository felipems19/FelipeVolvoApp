﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using felipe_santos_volvoapp.Models;

namespace felipe_santos_volvoapp.Data
{
    public class appContext : DbContext
    {
        public appContext(DbContextOptions<appContext> options)
            : base(options)
        {
        }

        public DbSet<felipe_santos_volvoapp.Models.Caminhao> Caminhao { get; set; }
    }
}
