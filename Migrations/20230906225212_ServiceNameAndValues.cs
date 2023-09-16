using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class ServiceNameAndValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Service", "Type" },
                values: new object[] { "Express Shipping", "Shipping" });

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Service", "Type" },
                values: new object[] { "Gift Wrapping", "Packaging" });

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Service", "Type" },
                values: new object[] { "Extended Warranty", "Warranty" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 52, 11, 993, DateTimeKind.Utc).AddTicks(2140));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Service", "Type" },
                values: new object[] { "", "Express Shipping" });

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Service", "Type" },
                values: new object[] { "", "Gift Wrapping" });

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Service", "Type" },
                values: new object[] { "", "Extended Warranty" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 6, 22, 49, 58, 431, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 49, 58, 431, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 49, 58, 431, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 49, 58, 431, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 49, 58, 431, DateTimeKind.Utc).AddTicks(4460));
        }
    }
}
