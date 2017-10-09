using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PizzaAppCore.Migrations
{
    public partial class UpdatePizzaTableProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_ExtraIngredients_ExtraIngredientsModelID1",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_ExtraIngredientsModelID1",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "ExtraIngredientsModelID1",
                table: "Pizza");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Pizza",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<int>(
                name: "ExtraIngredientsModelID",
                table: "Pizza",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_ExtraIngredientsModelID",
                table: "Pizza",
                column: "ExtraIngredientsModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_ExtraIngredients_ExtraIngredientsModelID",
                table: "Pizza",
                column: "ExtraIngredientsModelID",
                principalTable: "ExtraIngredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_ExtraIngredients_ExtraIngredientsModelID",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_ExtraIngredientsModelID",
                table: "Pizza");

            migrationBuilder.AlterColumn<byte>(
                name: "OrderId",
                table: "Pizza",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "ExtraIngredientsModelID",
                table: "Pizza",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ExtraIngredientsModelID1",
                table: "Pizza",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_ExtraIngredientsModelID1",
                table: "Pizza",
                column: "ExtraIngredientsModelID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_ExtraIngredients_ExtraIngredientsModelID1",
                table: "Pizza",
                column: "ExtraIngredientsModelID1",
                principalTable: "ExtraIngredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
