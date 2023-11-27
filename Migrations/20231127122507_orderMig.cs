using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class orderMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConsumerName",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "OrdersServices",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ServicesId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersServices", x => new { x.OrderId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_OrdersServices_AdditionalServices_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "AdditionalServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersServices_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsumerName", "DateCreated" },
                values: new object[] { "", new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsumerName", "DateCreated" },
                values: new object[] { "", new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConsumerName", "DateCreated" },
                values: new object[] { "", new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConsumerName", "DateCreated" },
                values: new object[] { "", new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConsumerName", "DateCreated" },
                values: new object[] { "", new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConsumerName", "DateCreated" },
                values: new object[] { "", new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConsumerName", "DateCreated" },
                values: new object[] { "", new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConsumerName", "DateCreated" },
                values: new object[] { "", new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConsumerName", "DateCreated" },
                values: new object[] { "", new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 4, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 5, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 6, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 7, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 9, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 10, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 11, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 12, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 13, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 14, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 15, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 16, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 17, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 18, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 19, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 20, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 21, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 22, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 23, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 24, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 25, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 26, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 27, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.CreateIndex(
                name: "IX_OrdersServices_ServicesId",
                table: "OrdersServices",
                column: "ServicesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersServices");

            migrationBuilder.DropColumn(
                name: "ConsumerName",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 4, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 5, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 6, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 7, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 9, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 10, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 11, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 12, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 13, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 14, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 15, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 16, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 17, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 18, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 19, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 20, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 21, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 22, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 23, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 24, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 25, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 26, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 27, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 24, 12, 11, 24, 953, DateTimeKind.Utc).AddTicks(2777));
        }
    }
}
