﻿// <auto-generated />
using System;
using HMT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HMT.Migrations
{
    [DbContext(typeof(HMTContext))]
    [Migration("20210628142456_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HMT.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Camping"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Footwear"
                        });
                });

            modelBuilder.Entity("HMT.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Email = "tranminhhien14@gmail.com",
                            Name = "Tran",
                            Phone = "7346292088"
                        });
                });

            modelBuilder.Entity("HMT.Models.PhotoModels.PDiv", b =>
                {
                    b.Property<string>("PDivID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PDivID");

                    b.ToTable("PDivs");

                    b.HasData(
                        new
                        {
                            PDivID = "B",
                            Name = "Bag"
                        },
                        new
                        {
                            PDivID = "S",
                            Name = "Shoes"
                        });
                });

            modelBuilder.Entity("HMT.Models.PhotoModels.PItem", b =>
                {
                    b.Property<string>("PItemID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDivID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PStoreID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PItemID");

                    b.HasIndex("PDivID");

                    b.HasIndex("PStoreID");

                    b.ToTable("PItems");

                    b.HasData(
                        new
                        {
                            PItemID = "1",
                            Image = "",
                            PDivID = "B",
                            PStoreID = "SO"
                        },
                        new
                        {
                            PItemID = "2",
                            Image = "",
                            PDivID = "S",
                            PStoreID = "SO"
                        },
                        new
                        {
                            PItemID = "3",
                            Image = "",
                            PDivID = "B",
                            PStoreID = "ST"
                        },
                        new
                        {
                            PItemID = "4",
                            Image = "",
                            PDivID = "S",
                            PStoreID = "ST"
                        });
                });

            modelBuilder.Entity("HMT.Models.PhotoModels.PStore", b =>
                {
                    b.Property<string>("PStoreID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PStoreID");

                    b.ToTable("PStores");

                    b.HasData(
                        new
                        {
                            PStoreID = "SO",
                            Name = "Store One"
                        },
                        new
                        {
                            PStoreID = "ST",
                            Name = "Store Two"
                        });
                });

            modelBuilder.Entity("HMT.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VendorID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("VendorID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 1,
                            Name = "Z Bag",
                            Price = 180m,
                            VendorID = 1
                        });
                });

            modelBuilder.Entity("HMT.Models.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("StoreID")
                        .HasColumnType("int");

                    b.HasKey("SaleID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("StoreID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("HMT.Models.Sold", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("SaleID")
                        .HasColumnType("int");

                    b.Property<int>("Item")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "SaleID");

                    b.HasIndex("SaleID");

                    b.ToTable("Solds");
                });

            modelBuilder.Entity("HMT.Models.Store", b =>
                {
                    b.Property<int>("StoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("StoreID");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            StoreID = 1,
                            City = "Troy",
                            State = "AL",
                            Street = "104 South Franklin Dr",
                            Zip = 36081
                        },
                        new
                        {
                            StoreID = 2,
                            City = "Troy",
                            State = "AL",
                            Street = "601 Elm Street",
                            Zip = 36081
                        },
                        new
                        {
                            StoreID = 3,
                            City = "Milford",
                            State = "CT",
                            Street = "192 Cedarhurst Ln",
                            Zip = 6461
                        });
                });

            modelBuilder.Entity("HMT.Models.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorID");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            VendorID = 1,
                            Name = "Pacifica Gear"
                        },
                        new
                        {
                            VendorID = 2,
                            Name = "Mountain King"
                        });
                });

            modelBuilder.Entity("HMT.Models.PhotoModels.PItem", b =>
                {
                    b.HasOne("HMT.Models.PhotoModels.PDiv", "PDiv")
                        .WithMany()
                        .HasForeignKey("PDivID");

                    b.HasOne("HMT.Models.PhotoModels.PStore", "PStore")
                        .WithMany()
                        .HasForeignKey("PStoreID");

                   
                });

            modelBuilder.Entity("HMT.Models.Product", b =>
                {
                    b.HasOne("HMT.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMT.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                   
                });

            modelBuilder.Entity("HMT.Models.Sale", b =>
                {
                    b.HasOne("HMT.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMT.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                   
                });

            modelBuilder.Entity("HMT.Models.Sold", b =>
                {
                    b.HasOne("HMT.Models.Product", "Product")
                        .WithMany("Solds")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMT.Models.Sale", "Sale")
                        .WithMany("Solds")
                        .HasForeignKey("SaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                   
                });

            modelBuilder.Entity("HMT.Models.Product", b =>
                {
                    
                });

            modelBuilder.Entity("HMT.Models.Sale", b =>
                {
                    
                });
#pragma warning restore 612, 618
        }
    }
}
