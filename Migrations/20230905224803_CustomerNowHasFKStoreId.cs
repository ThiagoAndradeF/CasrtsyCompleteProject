using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class CustomerNowHasFKStoreId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Customers_CustomerId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_CustomerId",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Stores");

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "StoreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "StoreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 5, 22, 48, 3, 335, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 22, 48, 3, 335, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 22, 48, 3, 335, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 22, 48, 3, 335, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 22, 48, 3, 335, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.CreateIndex(
                name: "IX_Customers_StoreId",
                table: "Customers",
                column: "StoreId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Stores_StoreId",
                table: "Customers",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Stores_StoreId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_StoreId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Stores",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 5, 22, 30, 14, 245, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 22, 30, 14, 245, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CustomerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                column: "CustomerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 22, 30, 14, 245, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 22, 30, 14, 245, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 9, 5, 22, 30, 14, 245, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.CreateIndex(
                name: "IX_Stores_CustomerId",
                table: "Stores",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Customers_CustomerId",
                table: "Stores",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
