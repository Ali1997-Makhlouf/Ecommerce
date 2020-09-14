using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using E_C_system.Models;

namespace E_C_system.Data
{
    public class ApplicationDbContext : IdentityDbContext<Client, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<E_C_system.Models.Order> Order { get; set; }
        public DbSet<E_C_system.Models.Product> Product { get; set; }
        public DbSet<E_C_system.Models.ProductOffer> ProductOffer { get; set; }
        public DbSet<E_C_system.Models.ProductPhoto> ProductPhoto { get; set; }
        public DbSet<E_C_system.Models.Address> Address { get; set; }
        public DbSet<E_C_system.Models.Category> Category { get; set; }
        public DbSet<E_C_system.Models.Delivery> Delivery { get; set; }
        public DbSet<E_C_system.Models.Offer> Offer { get; set; }
        public DbSet<E_C_system.Models.OrderProduct> OrderProduct { get; set; }
        public DbSet<E_C_system.Models.Session> Session { get; set; }
    }
}
