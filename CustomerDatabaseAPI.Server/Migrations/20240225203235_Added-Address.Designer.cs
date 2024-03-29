﻿// <auto-generated />
using CustomerDatabaseAPI.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerDatabaseAPI.Server.Migrations
{
    [DbContext(typeof(CustomerDatabaseAPIServerContext))]
    [Migration("20240225203235_Added-Address")]
    partial class AddedAddress
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.CompanyCall", b =>
                {
                    b.Property<int>("CallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CallId"));

                    b.Property<bool>("CallAnswered")
                        .HasColumnType("bit");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("CallId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CompanyCalls");
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.CustomerAddress", b =>
                {
                    b.Property<int>("CustAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustAddressId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<bool>("CurrentCustAddress")
                        .HasColumnType("bit");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("CustAddressId");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerAddress");
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmailId"));

                    b.Property<string>("CustEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("EmailId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustEmail");
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneId"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneId");

                    b.HasIndex("CustomerID");

                    b.ToTable("PhoneNumber");
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.CompanyCall", b =>
                {
                    b.HasOne("CustomerDatabaseAPI.Server.Models.Customer", null)
                        .WithMany("CompanyCalls")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.CustomerAddress", b =>
                {
                    b.HasOne("CustomerDatabaseAPI.Server.Models.Address", null)
                        .WithMany("CustAddress")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerDatabaseAPI.Server.Models.Customer", null)
                        .WithMany("CustomerAddress")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.Email", b =>
                {
                    b.HasOne("CustomerDatabaseAPI.Server.Models.Customer", null)
                        .WithMany("CustEmail")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.Phone", b =>
                {
                    b.HasOne("CustomerDatabaseAPI.Server.Models.Customer", null)
                        .WithMany("PhoneNumber")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.Address", b =>
                {
                    b.Navigation("CustAddress");
                });

            modelBuilder.Entity("CustomerDatabaseAPI.Server.Models.Customer", b =>
                {
                    b.Navigation("CompanyCalls");

                    b.Navigation("CustEmail");

                    b.Navigation("CustomerAddress");

                    b.Navigation("PhoneNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
