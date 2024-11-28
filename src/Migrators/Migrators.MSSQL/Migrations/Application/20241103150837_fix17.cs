using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fix17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "MetricDatas",
                newName: "MetricDatas",
                newSchema: "Catalog");

            migrationBuilder.RenameTable(
                name: "ListDatas",
                newName: "ListDatas",
                newSchema: "Catalog");

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                schema: "Catalog",
                table: "MetricDatas",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "root");

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                schema: "Catalog",
                table: "ListDatas",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "root");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                schema: "Catalog",
                table: "MetricDatas");

            migrationBuilder.DropColumn(
                name: "TenantId",
                schema: "Catalog",
                table: "ListDatas");

            migrationBuilder.RenameTable(
                name: "MetricDatas",
                schema: "Catalog",
                newName: "MetricDatas");

            migrationBuilder.RenameTable(
                name: "ListDatas",
                schema: "Catalog",
                newName: "ListDatas");
        }
    }
}
