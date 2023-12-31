﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomationSystem.Migrations
{
    /// <inheritdoc />
    public partial class tenth9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Techniks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Techniks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
