using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmailToStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Stores",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 4, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 5, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 6, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 7, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 9, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 10, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 11, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 12, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 13, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 14, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 15, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 16, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 17, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 18, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 19, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 20, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 21, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 22, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 23, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 24, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 25, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 26, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 27, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "");

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 10, 25, 1, 45, 30, 147, DateTimeKind.Utc).AddTicks(5782));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
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
    }
}
