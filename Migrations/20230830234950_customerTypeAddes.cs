using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class customerTypeAddes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "TypeDiscriminator",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Type", "TypeDiscriminator" },
                values: new object[] { "legal", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Type", "TypeDiscriminator" },
                values: new object[] { "natural", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 23, 49, 50, 430, DateTimeKind.Utc).AddTicks(8140));
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

            migrationBuilder.DropColumn(
                name: "TypeDiscriminator",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Customers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CNPJ", "CellPhone", "Email", "HomePhone", "Name", "Status", "Type" },
                values: new object[] { 2, 2, "12345678901234", "234-567-8901", "info@microsoft.com", "876-543-2109", "Microsoft Corp", true, 1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "CPF", "CellPhone", "Email", "HomePhone", "Name", "Status", "Type" },
                values: new object[] { 3, 3, "98765432109", "345-678-9012", "alice@example.com", "765-432-1098", "Alice Johnson", true, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 29, 23, 49, 15, 944, DateTimeKind.Utc).AddTicks(8770));
        }
    }
}
