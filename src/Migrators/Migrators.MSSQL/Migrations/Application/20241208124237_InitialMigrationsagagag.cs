using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class InitialMigrationsagagag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAvatar",
                schema: "House",
                table: "Motels");

            migrationBuilder.DropColumn(
                name: "UserFullName",
                schema: "House",
                table: "Motels");

            migrationBuilder.DropColumn(
                name: "UserPhone",
                schema: "House",
                table: "Motels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAvatar",
                schema: "House",
                table: "Motels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserFullName",
                schema: "House",
                table: "Motels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserPhone",
                schema: "House",
                table: "Motels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
