using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonOfCodSeafood.Migrations
{
    public partial class ImgColToProductTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Pictures");

            migrationBuilder.AddColumn<byte[]>(
                name: "Img",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Pictures",
                nullable: true);
        }
    }
}
