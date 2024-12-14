using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class InitialMigrationsqweui00 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                schema: "House",
                table: "Motels");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "House",
                table: "Motels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Features",
                schema: "House",
                table: "Motels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVip",
                schema: "House",
                table: "Motels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Features",
                schema: "House",
                table: "Motels");

            migrationBuilder.DropColumn(
                name: "IsVip",
                schema: "House",
                table: "Motels");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "House",
                table: "Motels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                schema: "House",
                table: "Motels",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "");
        }
    }
}
