using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class FixMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonthlyNewsletter",
                schema: "House",
                table: "Memberships");

            migrationBuilder.AddColumn<int>(
                name: "CountPost",
                schema: "House",
                table: "Memberships",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountPost",
                schema: "House",
                table: "Memberships");

            migrationBuilder.AddColumn<string>(
                name: "MonthlyNewsletter",
                schema: "House",
                table: "Memberships",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
