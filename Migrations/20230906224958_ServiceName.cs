using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class ServiceName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Service",
                table: "AdditionalServices",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 1,
                column: "Service",
                value: "");

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 2,
                column: "Service",
                value: "");

            migrationBuilder.UpdateData(
                table: "AdditionalServices",
                keyColumn: "Id",
                keyValue: 3,
                column: "Service",
                value: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Service",
                table: "AdditionalServices");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 6, 22, 21, 42, 368, DateTimeKind.Utc).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 21, 42, 368, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 21, 42, 368, DateTimeKind.Utc).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 21, 42, 368, DateTimeKind.Utc).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 6, 22, 21, 42, 368, DateTimeKind.Utc).AddTicks(2530));
        }
    }
}
