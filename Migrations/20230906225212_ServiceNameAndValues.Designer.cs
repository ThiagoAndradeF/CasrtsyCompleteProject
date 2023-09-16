﻿// <auto-generated />
using System;
using Cartsy.Api.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cartsy.Api.Migrations
{
    [DbContext(typeof(CartsyContext))]
    [Migration("20230906225212_ServiceNameAndValues")]
    partial class ServiceNameAndValues
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cartsy.Api.Entities.AdditionalServices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasPrecision(2, 10)
                        .HasColumnType("double precision");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("AdditionalServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 10.99,
                            Service = "Express Shipping",
                            Type = "Shipping"
                        },
                        new
                        {
                            Id = 2,
                            Price = 5.0,
                            Service = "Gift Wrapping",
                            Type = "Packaging"
                        },
                        new
                        {
                            Id = 3,
                            Price = 2.5,
                            Service = "Extended Warranty",
                            Type = "Warranty"
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character(8)")
                        .IsFixedLength();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character(2)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CEP = "12345678",
                            City = "Los Angeles",
                            Number = 123,
                            State = "California",
                            Street = "Main St",
                            UF = "CA"
                        },
                        new
                        {
                            Id = 2,
                            CEP = "87654321",
                            City = "New York City",
                            Number = 456,
                            State = "New York",
                            Street = "Broadway Ave",
                            UF = "NY"
                        },
                        new
                        {
                            Id = 3,
                            CEP = "98765432",
                            City = "Houston",
                            Number = 789,
                            State = "Texas",
                            Street = "Oak St",
                            UF = "TX"
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Consumer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character(11)")
                        .IsFixedLength();

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character(13)")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character(13)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Consumers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            CPF = "73473943096",
                            CellPhone = "123-456-7890",
                            Email = "linus@example.com",
                            HomePhone = "987-654-3210",
                            Name = "Linus Torvalds",
                            Status = true
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character(13)")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character(13)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<int>("TypeDiscriminator")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Customers", (string)null);

                    b.HasDiscriminator<int>("TypeDiscriminator");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("Price")
                        .HasPrecision(2, 10)
                        .HasColumnType("double precision");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.Property<int>("StoreId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.HasIndex("TypeId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "High-end smartphone",
                            Name = "Smartphone",
                            Price = 499.99000000000001,
                            Stock = 50,
                            StoreId = 1,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cotton crew-neck t-shirt",
                            Name = "T-Shirt",
                            Price = 19.989999999999998,
                            Stock = 100,
                            StoreId = 2,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bestselling science fiction book",
                            Name = "Sci-Fi Novel",
                            Price = 12.99,
                            Stock = 30,
                            StoreId = 3,
                            TypeId = 3
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Tax")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Tax = 10,
                            Type = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Tax = 5,
                            Type = "Clothing"
                        },
                        new
                        {
                            Id = 3,
                            Tax = 0,
                            Type = "Books"
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ConsumerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Price")
                        .HasPrecision(2, 10)
                        .HasColumnType("double precision");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<int>("StoreId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ConsumerId");

                    b.HasIndex("StoreId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConsumerId = 1,
                            Date = new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2120),
                            Price = 499.99000000000001,
                            StatusId = 1,
                            StoreId = 1
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.OrderItem", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.HasKey("ItemId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersItems", (string)null);

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            OrderId = 1,
                            CreatedAt = new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2140)
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            Status = "Processing"
                        },
                        new
                        {
                            Id = 3,
                            Status = "Shipped"
                        },
                        new
                        {
                            Id = 4,
                            Status = "Delivered"
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            CustomerId = 2,
                            Name = "FashionHub"
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            CustomerId = 3,
                            Name = "Book Haven"
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.StoreService", b =>
                {
                    b.Property<int>("ServicesId")
                        .HasColumnType("integer");

                    b.Property<int>("StoreId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("NOW()");

                    b.HasKey("ServicesId", "StoreId");

                    b.HasIndex("StoreId");

                    b.ToTable("StoresServices", (string)null);

                    b.HasData(
                        new
                        {
                            ServicesId = 1,
                            StoreId = 1,
                            CreatedAt = new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2130)
                        },
                        new
                        {
                            ServicesId = 2,
                            StoreId = 2,
                            CreatedAt = new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2140)
                        },
                        new
                        {
                            ServicesId = 3,
                            StoreId = 3,
                            CreatedAt = new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2140)
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.LegalCustomer", b =>
                {
                    b.HasBaseType("Cartsy.Api.Entities.Customer");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character(14)")
                        .IsFixedLength();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue(1);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            CellPhone = "234-567-8901",
                            Email = "info@microsoft.com",
                            HomePhone = "876-543-2109",
                            Name = "Microsoft Corp",
                            Status = true,
                            TypeDiscriminator = 1,
                            CNPJ = "12345678901234",
                            Type = "legal"
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.NaturalCustomer", b =>
                {
                    b.HasBaseType("Cartsy.Api.Entities.Customer");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character(11)")
                        .IsFixedLength();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("Customers", t =>
                        {
                            t.Property("Type")
                                .HasColumnName("NaturalCustomer_Type");
                        });

                    b.HasDiscriminator().HasValue(2);

                    b.HasData(
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            CellPhone = "345-678-9012",
                            Email = "alice@example.com",
                            HomePhone = "765-432-1098",
                            Name = "Alice Johnson",
                            Status = true,
                            TypeDiscriminator = 2,
                            CPF = "98765432109",
                            Type = "natural"
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Consumer", b =>
                {
                    b.HasOne("Cartsy.Api.Entities.Address", "Address")
                        .WithOne("Consumer")
                        .HasForeignKey("Cartsy.Api.Entities.Consumer", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Customer", b =>
                {
                    b.HasOne("Cartsy.Api.Entities.Address", "Address")
                        .WithOne("Customer")
                        .HasForeignKey("Cartsy.Api.Entities.Customer", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Item", b =>
                {
                    b.HasOne("Cartsy.Api.Entities.Store", "Store")
                        .WithMany("Items")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cartsy.Api.Entities.ItemType", "Type")
                        .WithMany("Items")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Order", b =>
                {
                    b.HasOne("Cartsy.Api.Entities.Consumer", "Consumer")
                        .WithMany("Orders")
                        .HasForeignKey("ConsumerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cartsy.Api.Entities.OrderStatus", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("ConsumerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cartsy.Api.Entities.Store", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consumer");

                    b.Navigation("Status");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.OrderItem", b =>
                {
                    b.HasOne("Cartsy.Api.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cartsy.Api.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Store", b =>
                {
                    b.HasOne("Cartsy.Api.Entities.Address", "Address")
                        .WithOne("Store")
                        .HasForeignKey("Cartsy.Api.Entities.Store", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cartsy.Api.Entities.Customer", "Customer")
                        .WithOne("Store")
                        .HasForeignKey("Cartsy.Api.Entities.Store", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.StoreService", b =>
                {
                    b.HasOne("Cartsy.Api.Entities.AdditionalServices", null)
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cartsy.Api.Entities.Store", null)
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Address", b =>
                {
                    b.Navigation("Consumer");

                    b.Navigation("Customer");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Consumer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Customer", b =>
                {
                    b.Navigation("Store")
                        .IsRequired();
                });

            modelBuilder.Entity("Cartsy.Api.Entities.ItemType", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Store", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
