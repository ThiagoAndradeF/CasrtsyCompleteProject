using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class testMockValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AdditionalServices",
                columns: new[] { "Id", "Price", "Type" },
                values: new object[,]
                {
                    { 1, 10.99, "Express Shipping" },
                    { 2, 5.0, "Gift Wrapping" },
                    { 3, 2.5, "Extended Warranty" }
                });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "Id", "Tax", "Type" },
                values: new object[,]
                {
                    { 1, 10, "Electronics" },
                    { 2, 5, "Clothing" },
                    { 3, 0, "Books" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Processing" },
                    { 3, "Shipped" },
                    { 4, "Delivered" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Name", "UF" },
                values: new object[,]
                {
                    { 1, "California", "CA" },
                    { 2, "New York", "NY" },
                    { 3, "Texas", "TX" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, "Los Angeles", 1 },
                    { 2, "New York City", 2 },
                    { 3, "Houston", 3 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CEP", "CityId", "Number", "Street" },
                values: new object[,]
                {
                    { 1, "12345678", 1, 123, "Main St" },
                    { 2, "87654321", 2, 456, "Broadway Ave" },
                    { 3, "98765432", 3, 789, "Oak St" }
                });

            migrationBuilder.InsertData(
                table: "Consumers",
                columns: new[] { "Id", "AddressId", "CPF", "CellPhone", "Email", "HomePhone", "Name", "Status" },
                values: new object[] { 1, 1, "73473943096", "123-456-7890", "linus@example.com", "987-654-3210", "Linus Torvalds", true });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CNPJ", "CellPhone", "Email", "HomePhone", "Name", "Status", "Type" },
                values: new object[] { 2, 2, "12345678901234", "234-567-8901", "info@microsoft.com", "876-543-2109", "Microsoft Corp", true, 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CPF", "CellPhone", "Email", "HomePhone", "Name", "Status", "Type" },
                values: new object[] { 3, 3, "98765432109", "345-678-9012", "alice@example.com", "765-432-1098", "Alice Johnson", true, 2 });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "ElectroMart" },
                    { 2, 2, "FashionHub" },
                    { 3, 3, "Book Haven" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock", "StoreId", "TypeId" },
                values: new object[,]
                {
                    { 1, "High-end smartphone", "Smartphone", 499.99000000000001, 50, 1, 1 },
                    { 2, "Cotton crew-neck t-shirt", "T-Shirt", 19.989999999999998, 100, 2, 2 },
                    { 3, "Bestselling science fiction book", "Sci-Fi Novel", 12.99, 30, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ConsumerId", "Date", "Price", "StatusId", "StoreId" },
                values: new object[] { 1, 1, new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8760), 499.99000000000001, 1, 1 });

            migrationBuilder.InsertData(
                table: "StoresServices",
                columns: new[] { "ServicesId", "StoreId", "CreatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8770) },
                    { 2, 2, new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8770) },
                    { 3, 3, new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8770) }
                });

            migrationBuilder.InsertData(
                table: "OrdersItems",
                columns: new[] { "ItemId", "OrderId", "CreatedAt" },
                values: new object[] { 1, 1, new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8780) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
