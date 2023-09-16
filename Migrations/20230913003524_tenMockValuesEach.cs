using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class tenMockValuesEach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Service", "Type" },
                values: new object[] { 8.0, "Deluxe Gift Wrapping", "Packaging" });

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Service", "Type" },
                values: new object[] { 4.5, "Extended Warranty Basic", "Warranty" });

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Service", "Type" },
                values: new object[] { 14.99, "Express International Shipping", "Shipping" });

            migrationBuilder.InsertData(
                table: "AdditionalServices",
                columns: new[] { "Id", "Price", "Service", "Type" },
                values: new object[,]
                {
                    { 4, 6.9900000000000002, "Standard Ground Shipping", "Shipping" },
                    { 5, 12.0, "Premium Gift Wrapping Plus", "Packaging" },
                    { 6, 3.5, "Extended Warranty Plus", "Warranty" },
                    { 7, 7.9900000000000002, "Two-Day Shipping", "Shipping" },
                    { 8, 10.0, "Eco-Friendly Packaging", "Packaging" },
                    { 9, 5.0, "Basic Warranty", "Warranty" },
                    { 10, 9.9900000000000002, "International Shipping", "Shipping" }
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CEP", "City", "Number", "State", "Street", "UF" },
                values: new object[] { "56789012", "Chicago", 309, "Illinois", "Michigan Ave", "IL" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CEP", "City", "Number", "State", "Street", "UF" },
                values: new object[] { "67890123", "Portland", 412, "Oregon", "Pearl St", "OR" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CEP", "City", "Number", "State", "Street", "UF" },
                values: new object[] { "78901234", "Phoenix", 523, "Arizona", "Desert Ave", "AZ" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CEP", "City", "Number", "State", "Street", "UF" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressId", "Email", "Name" },
                values: new object[] { 4, "legal1@example.com", "Legal Customer 1" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "Email", "Name" },
                values: new object[] { 5, "legal2@example.com", "Legal Customer 2" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressId", "CNPJ", "CellPhone", "Email", "HomePhone", "Name", "Type", "TypeDiscriminator" },
                values: new object[] { 6, "12345678901234", "234-567-8901", "legal3@example.com", "876-543-2109", "Legal Customer 3", "legal", 1 });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Tax", "Type" },
                values: new object[] { 9, "Fragrances" });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Tax", "Type" },
                values: new object[] { 6, "Toiletries" });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Tax", "Type" },
                values: new object[] { 8, "Outdoor Gear" });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "Id", "Tax", "Type" },
                values: new object[,]
                {
                    { 4, 15, "Appliances" },
                    { 5, 7, "Jewelry" },
                    { 6, 8, "Sporting Goods" },
                    { 7, 10, "Home Accessories" },
                    { 8, 6, "Beauty Products" },
                    { 9, 0, "Food & Beverages" },
                    { 10, 5, "Office Supplies" }
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "Energy-efficient refrigerator", "Refrigerator", 799.99000000000001, 25 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "Exquisite diamond necklace", "Diamond Necklace", 1499.99, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "Official NBA basketball", "Basketball", 29.989999999999998, 50 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock", "StoreId", "TypeId" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "Arrived at Destination");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Delayed");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: "Ready for Pickup");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: "Awaiting Payment");

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 5, "Partially Shipped" },
                    { 6, "Refunded" },
                    { 7, "On Hold" },
                    { 8, "Backordered" },
                    { 9, "In Transit" },
                    { 10, "Out for Delivery" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2530), 49.990000000000002 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsumerId", "DateCreated", "Price", "StoreId" },
                values: new object[] { 1, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2530), 29.989999999999998, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConsumerId", "DateCreated", "Price", "StoreId" },
                values: new object[] { 1, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2530), 19.989999999999998, 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ConsumerId", "DateCreated", "DateDelivered", "Price", "StatusId", "StoreId" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.990000000000002, 1, 2 },
                    { 5, 2, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.989999999999998, 2, 3 },
                    { 7, 3, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.989999999999998, 1, 3 },
                    { 9, 3, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2540), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.989999999999995, 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 4, "Store 1" });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 5, "Store 2" });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 6, "Store 3" });

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.InsertData(
                table: "StoresServices",
                columns: new[] { "ServicesId", "StoreId", "CreatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2510) },
                    { 1, 3, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2510) },
                    { 2, 1, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2510) },
                    { 2, 3, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2510) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CNPJ", "CellPhone", "Email", "HomePhone", "Name", "Status", "Type", "TypeDiscriminator" },
                values: new object[] { 4, 7, "12345678901234", "234-567-8901", "legal4@example.com", "876-543-2109", "Legal Customer 4", true, "legal", 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CPF", "CellPhone", "Email", "HomePhone", "Name", "Status", "NaturalCustomer_Type", "TypeDiscriminator" },
                values: new object[,]
                {
                    { 5, 8, "98765432109", "345-678-9012", "natural1@example.com", "765-432-1098", "Natural Customer 1", true, "natural", 2 },
                    { 6, 9, "98765432109", "345-678-9012", "natural2@example.com", "765-432-1098", "Natural Customer 2", true, "natural", 2 }
                });

            migrationBuilder.InsertData(
                table: "OrdersItems",
                columns: new[] { "ItemId", "OrderId", "CreatedAt" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 5, 2, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 6, 2, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 7, 3, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 8, 3, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 9, 3, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 10, 4, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 11, 4, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 12, 4, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 13, 5, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 14, 5, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2550) },
                    { 15, 5, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 19, 7, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 20, 7, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 21, 7, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 25, 9, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 26, 9, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 27, 9, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressId", "CustomerId", "Name" },
                values: new object[] { 4, 7, 4, "Store 4" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ConsumerId", "DateCreated", "DateDelivered", "Price", "StatusId", "StoreId" },
                values: new object[,]
                {
                    { 6, 2, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 59.990000000000002, 3, 4 },
                    { 8, 3, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2540), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49.990000000000002, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "StoresServices",
                columns: new[] { "ServicesId", "StoreId", "CreatedAt" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2510) },
                    { 2, 4, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2510) }
                });

            migrationBuilder.InsertData(
                table: "OrdersItems",
                columns: new[] { "ItemId", "OrderId", "CreatedAt" },
                values: new object[,]
                {
                    { 16, 6, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 17, 6, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 18, 6, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 22, 8, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 23, 8, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) },
                    { 24, 8, new DateTime(2023, 9, 13, 0, 35, 24, 670, DateTimeKind.Utc).AddTicks(2560) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 23, 8 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 26, 9 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 27, 9 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Service", "Type" },
                values: new object[] { 10.99, "Express Shipping", "Shipping" });

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Service", "Type" },
                values: new object[] { 5.0, "Gift Wrapping", "Packaging" });

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Service", "Type" },
                values: new object[] { 2.5, "Extended Warranty", "Warranty" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CEP", "City", "Number", "State", "Street", "UF" },
                values: new object[] { "12345678", "Los Angeles", 123, "California", "Main St", "CA" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CEP", "City", "Number", "State", "Street", "UF" },
                values: new object[] { "87654321", "New York City", 456, "New York", "Broadway Ave", "NY" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CEP", "City", "Number", "State", "Street", "UF" },
                values: new object[] { "98765432", "Houston", 789, "Texas", "Oak St", "TX" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressId", "Email", "Name" },
                values: new object[] { 1, "casas@bahia.com", "Dono da Casas Bahia" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "Email", "Name" },
                values: new object[] { 2, "info@microsoft.com", "Microsoft Corp" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CPF", "CellPhone", "Email", "HomePhone", "Name", "Status", "NaturalCustomer_Type", "TypeDiscriminator" },
                values: new object[] { 3, 3, "98765432109", "345-678-9012", "alice@example.com", "765-432-1098", "Alice Johnson", true, "natural", 2 });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Tax", "Type" },
                values: new object[] { 10, "Electronics" });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Tax", "Type" },
                values: new object[] { 5, "Clothing" });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Tax", "Type" },
                values: new object[] { 0, "Books" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "High-end smartphone", "Smartphone", 499.99000000000001, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "Cotton crew-neck t-shirt", "T-Shirt", 19.989999999999998, 100 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "Stock" },
                values: new object[] { "Bestselling science fiction book", "Sci-Fi Novel", 12.99, 30 });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Processing");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: "Shipped");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: "Delivered");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9590), 499.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsumerId", "DateCreated", "Price", "StoreId" },
                values: new object[] { 2, new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9590), 19.989999999999998, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConsumerId", "DateCreated", "Price", "StoreId" },
                values: new object[] { 3, new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9590), 12.99, 3 });

            migrationBuilder.InsertData(
                table: "OrdersItems",
                columns: new[] { "ItemId", "OrderId", "CreatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9610) },
                    { 2, 2, new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9610) },
                    { 3, 3, new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9610) }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 1, "Casas Bahia" });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 2, "FashionHub" });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 3, "Book Haven" });

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.InsertData(
                table: "StoresServices",
                columns: new[] { "ServicesId", "StoreId", "CreatedAt" },
                values: new object[] { 3, 3, new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9600) });
        }
    }
}
