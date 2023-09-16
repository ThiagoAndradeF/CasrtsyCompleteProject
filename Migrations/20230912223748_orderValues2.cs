using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class orderValues2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CNPJ", "CellPhone", "Email", "HomePhone", "Name", "Status", "Type", "TypeDiscriminator" },
                values: new object[] { 1, 1, "12345678901234", "234-567-8901", "casas@bahia.com", "876-543-2109", "Dono da Casas Bahia", true, "legal", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9610));

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

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 22, 37, 48, 478, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressId", "CustomerId", "Name" },
                values: new object[] { 1, 1, 1, "Casas Bahia" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3308));
        }
    }
}
