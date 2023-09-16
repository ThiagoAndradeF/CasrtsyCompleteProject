using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class orderValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Consumers",
                columns: new[] { "Id", "AddressId", "CPF", "CellPhone", "Email", "HomePhone", "Name", "Status" },
                values: new object[,]
                {
                    { 2, 2, "73473943096", "123-456-7890", "rafa@pava.com", "987-654-3210", "rafa pava", true },
                    { 3, 3, "73473943096", "123-456-7890", "ti@ago.com", "987-654-3210", "ti ago", true }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3316));

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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ConsumerId", "DateCreated", "DateDelivered", "Price", "StatusId", "StoreId" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3294), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.989999999999998, 2, 2 },
                    { 3, 3, new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3295), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.99, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrdersItems",
                columns: new[] { "ItemId", "OrderId", "CreatedAt" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3317) },
                    { 3, 3, new DateTime(2023, 9, 12, 9, 24, 12, 465, DateTimeKind.Utc).AddTicks(3318) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consumers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 9, 12, 9, 18, 25, 536, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 18, 25, 536, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 18, 25, 536, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 18, 25, 536, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 12, 9, 18, 25, 536, DateTimeKind.Utc).AddTicks(861));
        }
    }
}
