using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class renthomev2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motels_Categories_CategoryId",
                schema: "House",
                table: "Motels");

            migrationBuilder.DropIndex(
                name: "IX_Motels_CategoryId",
                schema: "House",
                table: "Motels");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                schema: "House",
                table: "Motels");

            migrationBuilder.DropColumn(
                name: "CategoryGroupId",
                schema: "Catalog",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "Catalog",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                schema: "Catalog",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "BedroomCount",
                schema: "House",
                table: "Motels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BathroomCount",
                schema: "House",
                table: "Motels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                schema: "House",
                table: "Motels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                schema: "House",
                table: "Motels");

            migrationBuilder.AlterColumn<int>(
                name: "BedroomCount",
                schema: "House",
                table: "Motels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BathroomCount",
                schema: "House",
                table: "Motels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                schema: "House",
                table: "Motels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryGroupId",
                schema: "Catalog",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "Catalog",
                table: "Categories",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                schema: "Catalog",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Motels_CategoryId",
                schema: "House",
                table: "Motels",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Motels_Categories_CategoryId",
                schema: "House",
                table: "Motels",
                column: "CategoryId",
                principalSchema: "Catalog",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
