﻿// <auto-generated />
using System;
using Atividade.Api.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cartsy.Api.Migrations
{
    [DbContext(typeof(CartsyContext))]
    [Migration("20230830234950_customerTypeAddes")]
    partial class customerTypeAddes
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
                            Type = "Express Shipping"
                        },
                        new
                        {
                            Id = 2,
                            Price = 5.0,
                            Type = "Gift Wrapping"
                        },
                        new
                        {
                            Id = 3,
                            Price = 2.5,
                            Type = "Extended Warranty"
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

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CEP = "12345678",
                            CityId = 1,
                            Number = 123,
                            Street = "Main St"
                        },
                        new
                        {
                            Id = 2,
                            CEP = "87654321",
                            CityId = 2,
                            Number = 456,
                            Street = "Broadway Ave"
                        },
                        new
                        {
                            Id = 3,
                            CEP = "98765432",
                            CityId = 3,
                            Number = 789,
                            Street = "Oak St"
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("StateId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Los Angeles",
                            StateId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "New York City",
                            StateId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Houston",
                            StateId = 3
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

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

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
                            Date = new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8130),
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
                            CreatedAt = new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8150)
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

            modelBuilder.Entity("Cartsy.Api.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character(2)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "California",
                            UF = "CA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "New York",
                            UF = "NY"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Texas",
                            UF = "TX"
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            Name = "ElectroMart"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            Name = "FashionHub"
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
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
                            CreatedAt = new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8140)
                        },
                        new
                        {
                            ServicesId = 2,
                            StoreId = 2,
                            CreatedAt = new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8140)
                        },
                        new
                        {
                            ServicesId = 3,
                            StoreId = 3,
                            CreatedAt = new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8140)
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
                            Type = "legal",
                            TypeDiscriminator = 1,
                            CNPJ = "12345678901234"
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
                            Type = "natural",
                            TypeDiscriminator = 2,
                            CPF = "98765432109"
                        });
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Address", b =>
                {
                    b.HasOne("Cartsy.Api.Entities.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.City", b =>
                {
                    b.HasOne("Cartsy.Api.Entities.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
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

                    b.Navigation("Address");
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

            modelBuilder.Entity("Cartsy.Api.Entities.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.Consumer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.ItemType", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Cartsy.Api.Entities.State", b =>
                {
                    b.Navigation("Cities");
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
