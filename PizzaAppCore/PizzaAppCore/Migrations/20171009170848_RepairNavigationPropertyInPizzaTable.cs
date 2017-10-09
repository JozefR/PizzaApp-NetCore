using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PizzaAppCore.Migrations
{
    public partial class RepairNavigationPropertyInPizzaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Order_OrderModelID",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Pizza");

            migrationBuilder.AlterColumn<int>(
                name: "OrderModelID",
                table: "Pizza",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Order_OrderModelID",
                table: "Pizza",
                column: "OrderModelID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Order_OrderModelID",
                table: "Pizza");

            migrationBuilder.AlterColumn<int>(
                name: "OrderModelID",
                table: "Pizza",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Pizza",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Order_OrderModelID",
                table: "Pizza",
                column: "OrderModelID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
