using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class UpdateWorker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                schema: "Catalog",
                table: "Workers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workers_CompanyId",
                schema: "Catalog",
                table: "Workers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Companies_CompanyId",
                schema: "Catalog",
                table: "Workers",
                column: "CompanyId",
                principalSchema: "Catalog",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Companies_CompanyId",
                schema: "Catalog",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_CompanyId",
                schema: "Catalog",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                schema: "Catalog",
                table: "Workers");
        }
    }
}
