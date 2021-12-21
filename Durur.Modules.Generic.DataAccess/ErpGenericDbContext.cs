using Durur.Modules.Generic.Entities.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Durur.Modules.Generic.DataAccess
{
    public class ErpGenericDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<Job> Jobs { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Warehouse> Warehouses { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<OrderStatus> Order_Statuses { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerAddress> Customer_Addresses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderedItem> Ordered_Items { get; set; }

        public DbSet<CompanyPosition> CompanyPositions { get; set; }

        public DbSet<EmployeeCompanyPosition> Employee_CompanyPositions { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-5HRP16U;Database=DururERP_db;uid=DefaultAppUser;pwd=App123456");
        //    /*string _sql = MigrationUtility.ReadSql(typeof(MigrationUtility), "Countries.sql");
        //    migrationBuilder.Sql(_sql);*/
        //}


        public ErpGenericDbContext(DbContextOptions<ErpGenericDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
