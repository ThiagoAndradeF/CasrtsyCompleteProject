using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class consumerRemoval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Consumers_ConsumerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_ConsumerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ConsumerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ConsumerId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 4, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 5, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 6, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 7, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 8, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 9, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 10, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 11, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 12, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 13, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 14, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 15, 5 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 16, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 17, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 18, 6 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 19, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 20, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 21, 7 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 22, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 23, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 24, 8 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 25, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 26, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 27, 9 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 4 },
                column: "CreatedAt",
                value: new DateTime(2023, 11, 27, 12, 33, 30, 194, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_StatusId",
                table: "Orders",
                column: "StatusId",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_StatusId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StatusId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ConsumerId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressId = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "character(11)", fixedLength: true, maxLength: 11, nullable: false),
                    CellPhone = table.Column<string>(type: "character(13)", fixedLength: true, maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    HomePhone = table.Column<string>(type: "character(13)", fixedLength: true, maxLength: 13, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consumers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Consumers",
                columns: new[] { "Id", "AddressId", "CPF", "CellPhone", "Email", "HomePhone", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 1, "73473943096", "123-456-7890", "linus@example.com", "987-654-3210", "Linus Torvalds", true },
                    { 2, 2, "73473943096", "123-456-7890", "rafa@pava.com", "987-654-3210", "rafa pava", true },
                    { 3, 3, "73473943096", "123-456-7890", "ti@ago.com", "987-654-3210", "ti ago", true }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConsumerId", "DateCreated" },
                values: new object[] { 1, new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConsumerId", "DateCreated" },
                values: new object[] { 1, new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConsumerId", "DateCreated" },
                values: new object[] { 1, new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConsumerId", "DateCreated" },
                values: new object[] { 2, new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConsumerId", "DateCreated" },
                values: new object[] { 2, new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConsumerId", "DateCreated" },
                values: new object[] { 2, new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConsumerId", "DateCreated" },
                values: new object[] { 3, new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConsumerId", "DateCreated" },
                values: new object[] { 3, new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConsumerId", "DateCreated" },
                values: new object[] { 3, new DateTime(2023, 11, 27, 12, 25, 7, 25, DateTimeKind.Utc).AddTicks(318) });

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
                name: "IX_Orders_ConsumerId",
                table: "Orders",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_AddressId",
                table: "Consumers",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Consumers_ConsumerId",
                table: "Orders",
                column: "ConsumerId",
                principalTable: "Consumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_ConsumerId",
                table: "Orders",
                column: "ConsumerId",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
