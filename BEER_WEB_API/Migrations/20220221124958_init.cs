﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BEER_WEB_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brewery = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BeerStyle = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleNumber = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BeerName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Vintage = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Purchased = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BestBeforeDate = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AlcoholContent = table.Column<decimal>(type: "decimal(4,1)", nullable: false),
                    BottleSize = table.Column<decimal>(type: "decimal(3,0)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(3,0)", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beers_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beers_ProductsId",
                table: "Beers",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
