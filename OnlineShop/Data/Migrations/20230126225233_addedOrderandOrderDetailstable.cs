using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Data.Migrations
{
    public partial class addedOrderandOrderDetailstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SpecialTag_SpecialTagId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialTag",
                table: "SpecialTag");

            migrationBuilder.RenameTable(
                name: "SpecialTag",
                newName: "SpecialTags");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialTags",
                table: "SpecialTags",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    PhoneNo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    PorductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_PorductId",
                        column: x => x.PorductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PorductId",
                table: "OrderDetails",
                column: "PorductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SpecialTags_SpecialTagId",
                table: "Products",
                column: "SpecialTagId",
                principalTable: "SpecialTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SpecialTags_SpecialTagId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialTags",
                table: "SpecialTags");

            migrationBuilder.RenameTable(
                name: "SpecialTags",
                newName: "SpecialTag");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialTag",
                table: "SpecialTag",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SpecialTag_SpecialTagId",
                table: "Products",
                column: "SpecialTagId",
                principalTable: "SpecialTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
