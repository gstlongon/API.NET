﻿using Ecommerce3Ads.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce3Ads.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EcommerceDB;ConnectRetryCount=0");
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
