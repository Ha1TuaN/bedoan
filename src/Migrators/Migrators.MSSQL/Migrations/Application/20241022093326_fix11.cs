using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fix11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                schema: "Catalog",
                table: "OrganizationUnits",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InvestmentCertificates",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ICNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveDuration = table.Column<int>(type: "int", nullable: true),
                    Investor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryRentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FactoryRentArea = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticBudgetRegistered = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticBudgetEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticBudgetImplemented = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestmentCertificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvestmentCertificates_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentCertificates_CompanyId",
                schema: "Catalog",
                table: "InvestmentCertificates",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentCertificates_ICNumber",
                schema: "Catalog",
                table: "InvestmentCertificates",
                column: "ICNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvestmentCertificates",
                schema: "Catalog");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                schema: "Catalog",
                table: "OrganizationUnits");
        }
    }
}
