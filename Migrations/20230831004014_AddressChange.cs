using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddressChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Addresses",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Addresses",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Addresses",
                type: "character(2)",
                fixedLength: true,
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "State", "UF" },
                values: new object[] { "Los Angeles", "California", "" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "State", "UF" },
                values: new object[] { "New York City", "New York", "" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "State", "UF" },
                values: new object[] { "Houston", "Texas", "" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 8, 31, 0, 40, 14, 89, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "OrdersItems",
                keyColumns: new[] { "ItemId", "OrderId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 0, 40, 14, 89, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 0, 40, 14, 89, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 0, 40, 14, 89, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "StoresServices",
                keyColumns: new[] { "ServicesId", "StoreId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTime(2023, 8, 31, 0, 40, 14, 89, DateTimeKind.Utc).AddTicks(7500));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Addresses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UF = table.Column<string>(type: "character(2)", fixedLength: true, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StateId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CityId",
                value: 3);

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

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Name", "UF" },
                values: new object[,]
                {
                    { 1, "California", "CA" },
                    { 2, "New York", "NY" },
                    { 3, "Texas", "TX" }
                });

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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "StateId" },
                values: new object[,]
                {
                    { 1, "Los Angeles", 1 },
                    { 2, "New York City", 2 },
                    { 3, "Houston", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
