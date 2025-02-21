﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobitelSystem.Migrations
{
    public partial class _3rd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
