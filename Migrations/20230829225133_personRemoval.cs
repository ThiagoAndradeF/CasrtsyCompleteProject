using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cartsy.Api.Migrations
{
    /// <inheritdoc />
    public partial class personRemoval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_IdCity",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_IdState",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemTypes_IdType",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Stores_IdStore",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_IdStatus",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Persons_IdConsumer",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_IdStore",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersItems_Items_ItemsId",
                table: "OrdersItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersItems_Orders_OrdersId",
                table: "OrdersItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresses_IdAddress",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Addresses_IdAddress",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_StoresServices_Stores_StoresId",
                table: "StoresServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoresServices",
                table: "StoresServices");

            migrationBuilder.DropIndex(
                name: "IX_StoresServices_StoresId",
                table: "StoresServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersItems",
                table: "OrdersItems");

            migrationBuilder.DropIndex(
                name: "IX_OrdersItems_OrdersId",
                table: "OrdersItems");

            migrationBuilder.DropIndex(
                name: "IX_Orders_IdStatus",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "StoresId",
                table: "StoresServices");

            migrationBuilder.DropColumn(
                name: "ItemsId",
                table: "OrdersItems");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "OrdersItems");

            migrationBuilder.DropColumn(
                name: "Consumer_CPF",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "IdStore",
                table: "StoresServices",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "IdService",
                table: "StoresServices",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "IdAddress",
                table: "Stores",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Stores_IdAddress",
                table: "Stores",
                newName: "IX_Stores_AddressId");

            migrationBuilder.RenameColumn(
                name: "IdOrder",
                table: "OrdersItems",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "IdItem",
                table: "OrdersItems",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "IdStore",
                table: "Orders",
                newName: "StoreId");

            migrationBuilder.RenameColumn(
                name: "IdStatus",
                table: "Orders",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "IdConsumer",
                table: "Orders",
                newName: "ConsumerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_IdStore",
                table: "Orders",
                newName: "IX_Orders_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_IdConsumer",
                table: "Orders",
                newName: "IX_Orders_ConsumerId");

            migrationBuilder.RenameColumn(
                name: "IdType",
                table: "Items",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "IdStore",
                table: "Items",
                newName: "StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_IdType",
                table: "Items",
                newName: "IX_Items_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_IdStore",
                table: "Items",
                newName: "IX_Items_StoreId");

            migrationBuilder.RenameColumn(
                name: "IdState",
                table: "Cities",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_IdState",
                table: "Cities",
                newName: "IX_Cities_StateId");

            migrationBuilder.RenameColumn(
                name: "IdCity",
                table: "Addresses",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_IdCity",
                table: "Addresses",
                newName: "IX_Addresses_CityId");

            migrationBuilder.RenameColumn(
                name: "IdAddress",
                table: "Customers",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_IdAddress",
                table: "Customers",
                newName: "IX_Customers_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoresServices",
                table: "StoresServices",
                columns: new[] { "ServicesId", "StoreId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersItems",
                table: "OrdersItems",
                columns: new[] { "ItemId", "OrderId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CellPhone = table.Column<string>(type: "character(13)", fixedLength: true, maxLength: 13, nullable: false),
                    HomePhone = table.Column<string>(type: "character(13)", fixedLength: true, maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    AddressId = table.Column<int>(type: "integer", nullable: false),
                    CPF = table.Column<string>(type: "character(11)", fixedLength: true, maxLength: 11, nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_StoresServices_StoreId",
                table: "StoresServices",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersItems_OrderId",
                table: "OrdersItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_AddressId",
                table: "Consumers",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemTypes_TypeId",
                table: "Items",
                column: "TypeId",
                principalTable: "ItemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Stores_StoreId",
                table: "Items",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersItems_Items_ItemId",
                table: "OrdersItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersItems_Orders_OrderId",
                table: "OrdersItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Addresses_AddressId",
                table: "Stores",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoresServices_Stores_StoreId",
                table: "StoresServices",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemTypes_TypeId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Stores_StoreId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Consumers_ConsumerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_ConsumerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersItems_Items_ItemId",
                table: "OrdersItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersItems_Orders_OrderId",
                table: "OrdersItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Addresses_AddressId",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_StoresServices_Stores_StoreId",
                table: "StoresServices");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoresServices",
                table: "StoresServices");

            migrationBuilder.DropIndex(
                name: "IX_StoresServices_StoreId",
                table: "StoresServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersItems",
                table: "OrdersItems");

            migrationBuilder.DropIndex(
                name: "IX_OrdersItems_OrderId",
                table: "OrdersItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Persons");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "StoresServices",
                newName: "IdStore");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "StoresServices",
                newName: "IdService");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Stores",
                newName: "IdAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Stores_AddressId",
                table: "Stores",
                newName: "IX_Stores_IdAddress");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrdersItems",
                newName: "IdOrder");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "OrdersItems",
                newName: "IdItem");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Orders",
                newName: "IdStore");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Orders",
                newName: "IdStatus");

            migrationBuilder.RenameColumn(
                name: "ConsumerId",
                table: "Orders",
                newName: "IdConsumer");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StoreId",
                table: "Orders",
                newName: "IX_Orders_IdStore");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ConsumerId",
                table: "Orders",
                newName: "IX_Orders_IdConsumer");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Items",
                newName: "IdType");

            migrationBuilder.RenameColumn(
                name: "StoreId",
                table: "Items",
                newName: "IdStore");

            migrationBuilder.RenameIndex(
                name: "IX_Items_TypeId",
                table: "Items",
                newName: "IX_Items_IdType");

            migrationBuilder.RenameIndex(
                name: "IX_Items_StoreId",
                table: "Items",
                newName: "IX_Items_IdStore");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "Cities",
                newName: "IdState");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                newName: "IX_Cities_IdState");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Addresses",
                newName: "IdCity");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                newName: "IX_Addresses_IdCity");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Persons",
                newName: "IdAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_AddressId",
                table: "Persons",
                newName: "IX_Persons_IdAddress");

            migrationBuilder.AddColumn<int>(
                name: "StoresId",
                table: "StoresServices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemsId",
                table: "OrdersItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "OrdersItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Consumer_CPF",
                table: "Persons",
                type: "character(11)",
                fixedLength: true,
                maxLength: 11,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoresServices",
                table: "StoresServices",
                columns: new[] { "ServicesId", "StoresId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersItems",
                table: "OrdersItems",
                columns: new[] { "ItemsId", "OrdersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StoresServices_StoresId",
                table: "StoresServices",
                column: "StoresId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersItems_OrdersId",
                table: "OrdersItems",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IdStatus",
                table: "Orders",
                column: "IdStatus");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_IdCity",
                table: "Addresses",
                column: "IdCity",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_IdState",
                table: "Cities",
                column: "IdState",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemTypes_IdType",
                table: "Items",
                column: "IdType",
                principalTable: "ItemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Stores_IdStore",
                table: "Items",
                column: "IdStore",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_IdStatus",
                table: "Orders",
                column: "IdStatus",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Persons_IdConsumer",
                table: "Orders",
                column: "IdConsumer",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_IdStore",
                table: "Orders",
                column: "IdStore",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersItems_Items_ItemsId",
                table: "OrdersItems",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersItems_Orders_OrdersId",
                table: "OrdersItems",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Addresses_IdAddress",
                table: "Persons",
                column: "IdAddress",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Addresses_IdAddress",
                table: "Stores",
                column: "IdAddress",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoresServices_Stores_StoresId",
                table: "StoresServices",
                column: "StoresId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
