using Core.Entities;
using Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    internal class CarDbContext : IdentityDbContext<User>
    {
        public CarDbContext() : base() { }
        public CarDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedYears();
            modelBuilder.SeedModels();
            modelBuilder.SeedMakes();
            modelBuilder.SeedEngines();
            modelBuilder.SeedCars();
            //

            //DbContextExtensions.SeedCars(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connStr = "workstation id=CarsShop.mssql.somee.com;packet size=4096;user id=Soneta_SQLLogin_3;pwd=lxkq3lgzto;data source=CarsShop.mssql.somee.com;persist security info=False;initial catalog=CarsShop";
            optionsBuilder.UseSqlServer(connStr);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
