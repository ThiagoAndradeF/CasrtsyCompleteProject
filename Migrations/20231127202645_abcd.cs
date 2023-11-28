using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Atividade.Api.Migrations
{
    /// <inheritdoc />
    public partial class abcd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<double>(type: "double precision", precision: 2, scale: 10, nullable: false),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Service = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CEP = table.Column<string>(type: "character(8)", fixedLength: true, maxLength: 8, nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    City = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UF = table.Column<string>(type: "character(2)", fixedLength: true, maxLength: 2, nullable: false),
                    Street = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Tax = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CellPhone = table.Column<string>(type: "character(13)", fixedLength: true, maxLength: 13, nullable: false),
                    HomePhone = table.Column<string>(type: "character(13)", fixedLength: true, maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TypeDiscriminator = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    AddressId = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    CNPJ = table.Column<string>(type: "character(14)", fixedLength: true, maxLength: 14, nullable: true),
                    NaturalCustomer_Type = table.Column<string>(type: "text", nullable: true),
                    CPF = table.Column<string>(type: "character(11)", fixedLength: true, maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    AddressId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Price = table.Column<double>(type: "double precision", precision: 2, scale: 10, nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Stock = table.Column<int>(type: "integer", nullable: false),
                    StoreId = table.Column<int>(type: "integer", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_ItemTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<double>(type: "double precision", precision: 2, scale: 10, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StoreId = table.Column<int>(type: "integer", nullable: false),
                    ConsumerName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoresServices",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "integer", nullable: false),
                    ServicesId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoresServices", x => new { x.ServicesId, x.StoreId });
                    table.ForeignKey(
                        name: "FK_StoresServices_AdditionalServices_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "AdditionalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoresServices_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersItems", x => new { x.ItemId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrdersItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersServices",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ServicesId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersServices", x => new { x.OrderId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_OrdersServices_AdditionalServices_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "AdditionalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersServices_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdditionalServices",
                columns: new[] { "Id", "Price", "Service", "Type" },
                values: new object[,]
                {
                    { 1, 8.0, "Deluxe Gift Wrapping", "Packaging" },
                    { 2, 4.5, "Extended Warranty Basic", "Warranty" },
                    { 3, 14.99, "Express International Shipping", "Shipping" },
                    { 4, 6.9900000000000002, "Standard Ground Shipping", "Shipping" },
                    { 5, 12.0, "Premium Gift Wrapping Plus", "Packaging" },
                    { 6, 3.5, "Extended Warranty Plus", "Warranty" },
                    { 7, 7.9900000000000002, "Two-Day Shipping", "Shipping" },
                    { 8, 10.0, "Eco-Friendly Packaging", "Packaging" },
                    { 9, 5.0, "Basic Warranty", "Warranty" },
                    { 10, 9.9900000000000002, "International Shipping", "Shipping" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CEP", "City", "Number", "State", "Street", "UF" },
                values: new object[,]
                {
                    { 1, "56789012", "Chicago", 309, "Illinois", "Michigan Ave", "IL" },
                    { 2, "67890123", "Portland", 412, "Oregon", "Pearl St", "OR" },
                    { 3, "78901234", "Phoenix", 523, "Arizona", "Desert Ave", "AZ" },
                    { 4, "89012345", "Miami", 634, "Florida", "Ocean Dr", "FL" },
                    { 5, "90123456", "Nashville", 745, "Tennessee", "Music Rd", "TN" },
                    { 6, "12345678", "San Francisco", 123, "California", "Market St", "CA" },
                    { 7, "87654321", "Boston", 456, "Massachusetts", "Commonwealth Ave", "MA" },
                    { 8, "23456789", "Seattle", 789, "Washington", "Pine St", "WA" },
                    { 9, "34567890", "Austin", 101, "Texas", "6th Street", "TX" },
                    { 10, "45678901", "Denver", 210, "Colorado", "Broadway St", "CO" },
                    { 11, "56789012", "Chicago", 309, "Illinois", "Michigan Ave", "IL" },
                    { 12, "67890123", "Portland", 412, "Oregon", "Pearl St", "OR" },
                    { 13, "78901234", "Phoenix", 523, "Arizona", "Desert Ave", "AZ" },
                    { 14, "89012345", "Miami", 634, "Florida", "Ocean Dr", "FL" },
                    { 15, "90123456", "Nashville", 745, "Tennessee", "Music Rd", "TN" },
                    { 16, "12345678", "San Francisco", 123, "California", "Market St", "CA" },
                    { 17, "87654321", "Boston", 456, "Massachusetts", "Commonwealth Ave", "MA" },
                    { 18, "23456789", "Seattle", 789, "Washington", "Pine St", "WA" },
                    { 19, "34567890", "Austin", 101, "Texas", "6th Street", "TX" },
                    { 20, "45678901", "Denver", 210, "Colorado", "Broadway St", "CO" }
                });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "Id", "Tax", "Type" },
                values: new object[,]
                {
                    { 1, 9, "Fragrances" },
                    { 2, 6, "Toiletries" },
                    { 3, 8, "Outdoor Gear" },
                    { 4, 15, "Appliances" },
                    { 5, 7, "Jewelry" },
                    { 6, 8, "Sporting Goods" },
                    { 7, 10, "Home Accessories" },
                    { 8, 6, "Beauty Products" },
                    { 9, 0, "Food & Beverages" },
                    { 10, 5, "Office Supplies" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CNPJ", "CellPhone", "Email", "HomePhone", "Name", "Status", "Type", "TypeDiscriminator" },
                values: new object[,]
                {
                    { 1, 4, "12345678901234", "234-567-8901", "legal1@example.com", "876-543-2109", "Legal Customer 1", true, "legal", 1 },
                    { 2, 5, "12345678901234", "234-567-8901", "legal2@example.com", "876-543-2109", "Legal Customer 2", true, "legal", 1 },
                    { 3, 6, "12345678901234", "234-567-8901", "legal3@example.com", "876-543-2109", "Legal Customer 3", true, "legal", 1 },
                    { 4, 7, "12345678901234", "234-567-8901", "legal4@example.com", "876-543-2109", "Legal Customer 4", true, "legal", 1 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CPF", "CellPhone", "Email", "HomePhone", "Name", "Status", "NaturalCustomer_Type", "TypeDiscriminator" },
                values: new object[,]
                {
                    { 5, 8, "98765432109", "345-678-9012", "natural1@example.com", "765-432-1098", "Natural Customer 1", true, "natural", 2 },
                    { 6, 9, "98765432109", "345-678-9012", "natural2@example.com", "765-432-1098", "Natural Customer 2", true, "natural", 2 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressId", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 4, "", "Store 1", "" },
                    { 2, 5, "", "Store 2", "" },
                    { 3, 6, "", "Store 3", "" },
                    { 4, 7, "", "Store 4", "" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock", "StoreId", "TypeId" },
                values: new object[,]
                {
                    { 1, "Energy-efficient refrigerator", "Refrigerator", 799.99000000000001, 25, 1, 1 },
                    { 2, "Exquisite diamond necklace", "Diamond Necklace", 1499.99, 10, 2, 2 },
                    { 3, "Official NBA basketball", "Basketball", 29.989999999999998, 50, 3, 3 },
                    { 4, "Official NBA basketball", "Item 4", 29.989999999999998, 50, 3, 3 },
                    { 5, "Official NBA basketball", "Item 5", 29.989999999999998, 50, 3, 3 },
                    { 6, "Official NBA basketball", "Item 6", 29.989999999999998, 50, 3, 3 },
                    { 7, "Official NBA basketball", "Item 7", 29.989999999999998, 50, 3, 3 },
                    { 8, "Official NBA basketball", "Item 8", 29.989999999999998, 50, 3, 3 },
                    { 9, "Official NBA basketball", "Item 9", 29.989999999999998, 50, 3, 3 },
                    { 10, "Official NBA basketball", "Item 10", 29.989999999999998, 50, 2, 3 },
                    { 11, "Official NBA basketball", "Item 11", 29.989999999999998, 50, 2, 3 },
                    { 12, "Official NBA basketball", "Item 12", 29.989999999999998, 50, 2, 3 },
                    { 13, "Official NBA basketball", "Item 13", 29.989999999999998, 50, 2, 3 },
                    { 14, "Official NBA basketball", "Item 14", 29.989999999999998, 50, 2, 3 },
                    { 15, "Official NBA basketball", "Item 15", 29.989999999999998, 50, 2, 3 },
                    { 16, "Official NBA basketball", "Item 16", 29.989999999999998, 50, 1, 3 },
                    { 17, "Official NBA basketball", "Item 17", 29.989999999999998, 50, 1, 3 },
                    { 18, "Official NBA basketball", "Item 18", 29.989999999999998, 50, 1, 3 },
                    { 19, "Official NBA basketball", "Item 19", 29.989999999999998, 50, 1, 3 },
                    { 20, "Official NBA basketball", "Item 20", 29.989999999999998, 50, 1, 3 },
                    { 21, "Official NBA basketball", "Item 21", 29.989999999999998, 50, 1, 3 },
                    { 22, "Official NBA basketball", "Item 22", 29.989999999999998, 50, 1, 3 },
                    { 23, "Official NBA basketball", "Item 23", 29.989999999999998, 50, 1, 3 },
                    { 24, "Official NBA basketball", "Item 24", 29.989999999999998, 50, 1, 3 },
                    { 25, "Official NBA basketball", "Item 25", 29.989999999999998, 50, 1, 3 },
                    { 26, "Official NBA basketball", "Item 26", 29.989999999999998, 50, 1, 3 },
                    { 27, "Official NBA basketball", "Item 27", 29.989999999999998, 50, 1, 3 },
                    { 28, "Official NBA basketball", "Item 28", 29.989999999999998, 50, 1, 3 },
                    { 29, "Official NBA basketball", "Item 29", 29.989999999999998, 50, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ConsumerName", "DateCreated", "Price", "StoreId" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1607), 49.990000000000002, 1 },
                    { 2, "", new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1608), 29.989999999999998, 1 },
                    { 3, "", new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1609), 19.989999999999998, 2 },
                    { 4, "", new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1610), 39.990000000000002, 2 },
                    { 5, "", new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1611), 19.989999999999998, 3 },
                    { 6, "", new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1612), 59.990000000000002, 4 },
                    { 7, "", new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1613), 29.989999999999998, 3 },
                    { 8, "", new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1614), 49.990000000000002, 4 },
                    { 9, "", new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1615), 69.989999999999995, 1 }
                });

            migrationBuilder.InsertData(
                table: "StoresServices",
                columns: new[] { "ServicesId", "StoreId", "CreatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1583) },
                    { 1, 2, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1586) },
                    { 1, 3, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1588) },
                    { 1, 4, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1589) },
                    { 2, 1, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1585) },
                    { 2, 2, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1587) },
                    { 2, 3, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1588) },
                    { 2, 4, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1590) }
                });

            migrationBuilder.InsertData(
                table: "OrdersItems",
                columns: new[] { "ItemId", "OrderId", "CreatedAt" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1657) },
                    { 5, 2, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1658) },
                    { 6, 2, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1659) },
                    { 7, 3, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1659) },
                    { 8, 3, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1660) },
                    { 9, 3, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1661) },
                    { 10, 4, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1661) },
                    { 11, 4, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1662) },
                    { 12, 4, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1663) },
                    { 13, 5, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1664) },
                    { 14, 5, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1665) },
                    { 15, 5, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1665) },
                    { 16, 6, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1666) },
                    { 17, 6, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1667) },
                    { 18, 6, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1667) },
                    { 19, 7, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1668) },
                    { 20, 7, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1669) },
                    { 21, 7, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1670) },
                    { 22, 8, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1670) },
                    { 23, 8, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1671) },
                    { 24, 8, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1672) },
                    { 25, 9, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1673) },
                    { 26, 9, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1673) },
                    { 27, 9, new DateTime(2023, 11, 27, 20, 26, 44, 888, DateTimeKind.Utc).AddTicks(1674) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_StoreId",
                table: "Items",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TypeId",
                table: "Items",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreId",
                table: "Orders",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersItems_OrderId",
                table: "OrdersItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersServices_ServicesId",
                table: "OrdersServices",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_AddressId",
                table: "Stores",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoresServices_StoreId",
                table: "StoresServices",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrdersItems");

            migrationBuilder.DropTable(
                name: "OrdersServices");

            migrationBuilder.DropTable(
                name: "StoresServices");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AdditionalServices");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
