using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerDatabaseAPI.Server.Models;
using System.Reflection.Emit;


namespace CustomerDatabaseAPI.Server.Data
{
    public class CustomerDatabaseAPIServerContext : DbContext
    {
        

        public DbSet<CustomerDatabaseAPI.Server.Models.Customer> Customer { get; set; } 
            //= default!;

        public DbSet<CustomerDatabaseAPI.Server.Models.Address> Address { get; set; } 

        public DbSet<CustomerDatabaseAPI.Server.Models.CustomerAddress> CustomerAddress { get; set; }

        public DbSet<CustomerDatabaseAPI.Server.Models.Email> CustEmail { get; set; }

      // public DbSet<Email> Email { get; set; }

        public DbSet<CustomerDatabaseAPI.Server.Models.Phone> PhoneNumber { get; set; }

        public DbSet<CustomerDatabaseAPI.Server.Models.CompanyCall> CompanyCalls { get; set; }

        public CustomerDatabaseAPIServerContext(DbContextOptions<CustomerDatabaseAPIServerContext> options)
            : base(options)
        {
           
        }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Customer>()
        //        .HasData(new Customer
        //        { CustomerId = 1, FirstName = "Jane", LastName = "Vil" },

        //        new Customer
        //        { CustomerId = 2, FirstName = "John", LastName = "Doe" }
        //        );

        //    modelBuilder.Entity<Email>().HasData(

        //       new Email { EmailId = 1, CustomerId = 1, CustEmail = "jane.vil@gmail.com" },

        //       new Email { EmailId = 2, CustomerId = 2, CustEmail = "John.doe@hotmail.com" }

        //       );



        //    modelBuilder.Entity<Phone>().HasData(

        //        new Phone { PhoneId = 1, CustomerID = 1, PhoneNumber = "3673221100" },

        //        new Phone { PhoneId = 2, CustomerID = 2, PhoneNumber = "7890123456" }

        //        );



        //    base.OnModelCreating(modelBuilder);



        //}


    }
}
