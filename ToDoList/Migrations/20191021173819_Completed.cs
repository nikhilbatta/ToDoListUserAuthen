﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Migrations
{
    public partial class Completed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Items",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Items");
        }
    }
}
