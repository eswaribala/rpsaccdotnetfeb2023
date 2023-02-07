﻿// <auto-generated />
using System;
using CustomerAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerAPI.Migrations
{
    [DbContext(typeof(BankingContext))]
    [Migration("20230206165335_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CustomerAPI.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("AddressId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("City");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint")
                        .HasColumnName("CustomerId_FK");

                    b.Property<string>("DoorNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DoorNo");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int")
                        .HasColumnName("PostalCode");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("StreetName");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("CustomerAPI.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CustomerId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CustomerId"), 1L, 1);

                    b.Property<long>("ContactNo")
                        .HasMaxLength(10)
                        .HasColumnType("bigint")
                        .HasColumnName("ContactNo");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("CustomerAPI.Models.Corporate", b =>
                {
                    b.HasBaseType("CustomerAPI.Models.Customer");

                    b.Property<int>("CompanyType")
                        .HasColumnType("int")
                        .HasColumnName("CompanyType");

                    b.ToTable("Corporate", (string)null);
                });

            modelBuilder.Entity("CustomerAPI.Models.Individual", b =>
                {
                    b.HasBaseType("CustomerAPI.Models.Customer");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2")
                        .HasColumnName("DOB");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("Gender");

                    b.ToTable("Individual", (string)null);
                });

            modelBuilder.Entity("CustomerAPI.Models.Address", b =>
                {
                    b.HasOne("CustomerAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CustomerAPI.Models.Customer", b =>
                {
                    b.OwnsOne("CustomerAPI.Models.FullName", "FullName", b1 =>
                        {
                            b1.Property<long>("CustomerId")
                                .HasColumnType("bigint");

                            b1.Property<string>("FirstName")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("LastName");

                            b1.Property<string>("MiddleName")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("MiddleName");

                            b1.HasKey("CustomerId");

                            b1.ToTable("Customer");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");
                        });

                    b.Navigation("FullName");
                });

            modelBuilder.Entity("CustomerAPI.Models.Corporate", b =>
                {
                    b.HasOne("CustomerAPI.Models.Customer", null)
                        .WithOne()
                        .HasForeignKey("CustomerAPI.Models.Corporate", "CustomerId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerAPI.Models.Individual", b =>
                {
                    b.HasOne("CustomerAPI.Models.Customer", null)
                        .WithOne()
                        .HasForeignKey("CustomerAPI.Models.Individual", "CustomerId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
