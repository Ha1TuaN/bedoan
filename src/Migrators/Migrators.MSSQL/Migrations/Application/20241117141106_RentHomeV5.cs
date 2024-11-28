using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class RentHomeV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Star",
                schema: "House",
                table: "Motels",
                newName: "UserPhone");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAvatar",
                schema: "House",
                table: "Motels");

            migrationBuilder.DropColumn(
                name: "UserFullName",
                schema: "House",
                table: "Motels");

            migrationBuilder.RenameColumn(
                name: "UserPhone",
                schema: "House",
                table: "Motels",
                newName: "Star");
        }
    }
}
