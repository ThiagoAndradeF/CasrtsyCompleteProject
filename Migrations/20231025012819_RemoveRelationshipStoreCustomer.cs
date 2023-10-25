using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRelationshipStoreCustomer : Migration
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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 4, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 5, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 6, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 7, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 9, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 10, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 11, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 12, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 13, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 14, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 15, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 16, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 17, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 18, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 19, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 20, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 21, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 22, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 23, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 24, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 25, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 26, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 27, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 28, 19, 207, DateTimeKind.Utc).AddTicks(806));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Stores",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 4, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 5, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 6, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 7, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 9, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 10, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 11, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 12, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 13, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 14, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 15, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 16, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 17, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 18, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 19, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 20, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 21, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 22, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 23, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 24, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 25, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 26, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 27, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CustomerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                column: "CustomerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 4,
                column: "CustomerId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 24, 48, 214, DateTimeKind.Utc).AddTicks(1889));

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
                principalColumn: "Id");
        }
    }
}
