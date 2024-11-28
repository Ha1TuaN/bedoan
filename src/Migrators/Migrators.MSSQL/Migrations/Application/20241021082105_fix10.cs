using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fix10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarPath",
                schema: "Catalog",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OrganizationUnitId",
                schema: "Catalog",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_OrganizationUnitId",
                schema: "Catalog",
                table: "Companies",
                column: "OrganizationUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_OrganizationUnits_OrganizationUnitId",
                schema: "Catalog",
                table: "Companies",
                column: "OrganizationUnitId",
                principalSchema: "Catalog",
                principalTable: "OrganizationUnits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_OrganizationUnits_OrganizationUnitId",
                schema: "Catalog",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_OrganizationUnitId",
                schema: "Catalog",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "AvatarPath",
                schema: "Catalog",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "OrganizationUnitId",
                schema: "Catalog",
                table: "Companies");
        }
    }
}
