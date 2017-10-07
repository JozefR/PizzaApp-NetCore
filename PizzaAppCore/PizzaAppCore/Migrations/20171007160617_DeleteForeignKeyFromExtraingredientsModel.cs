using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PizzaAppCore.Migrations
{
    public partial class DeleteForeignKeyFromExtraingredientsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraIngredients_Pizza_PizzaModelID",
                table: "ExtraIngredients");

            migrationBuilder.DropIndex(
                name: "IX_ExtraIngredients_PizzaModelID",
                table: "ExtraIngredients");

            migrationBuilder.DropColumn(
                name: "PizzaModelID",
                table: "ExtraIngredients");

            migrationBuilder.AddColumn<int>(
                name: "ExtraIngredientsModelID1",
                table: "Pizza",
                type: "int",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PizzaModelID",
                table: "ExtraIngredients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExtraIngredients_PizzaModelID",
                table: "ExtraIngredients",
                column: "PizzaModelID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraIngredients_Pizza_PizzaModelID",
                table: "ExtraIngredients",
                column: "PizzaModelID",
                principalTable: "Pizza",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
