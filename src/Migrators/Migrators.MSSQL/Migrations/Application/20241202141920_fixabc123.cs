using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fixabc123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Motels_MotelId",
                schema: "Identity",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_MotelId",
                schema: "Identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MotelId",
                schema: "Identity",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MotelId",
                schema: "Identity",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_MotelId",
                schema: "Identity",
                table: "Users",
                column: "MotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Motels_MotelId",
                schema: "Identity",
                table: "Users",
                column: "MotelId",
                principalSchema: "House",
                principalTable: "Motels",
                principalColumn: "Id");
        }
    }
}
