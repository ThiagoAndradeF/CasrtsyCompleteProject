using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class orderHasPropDateDelivered : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Orders",
                newName: "DateDelivered");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateDelivered" },
                values: new object[] { new DateTime(2023, 9, 12, 9, 18, 25, 536, DateTimeKind.Utc).AddTicks(847), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "DateDelivered",
                table: "Orders",
                newName: "Date");

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
    }
}
