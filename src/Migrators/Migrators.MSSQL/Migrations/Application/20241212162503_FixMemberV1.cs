using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class FixMemberV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Utilities",
                schema: "House",
                table: "Memberships");

            migrationBuilder.AddColumn<bool>(
                name: "IsVip",
                schema: "House",
                table: "Memberships",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVip",
                schema: "House",
                table: "Memberships");

            migrationBuilder.AddColumn<string>(
                name: "Utilities",
                schema: "House",
                table: "Memberships",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
