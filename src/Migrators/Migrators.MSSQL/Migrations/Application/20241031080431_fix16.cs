using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fix16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "Catalog",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReportSubmitteds",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PeriodNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportYear = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentScan = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ReportSubmitteds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportSubmitteds_PeriodNumbers_PeriodNumberId",
                        column: x => x.PeriodNumberId,
                        principalSchema: "Catalog",
                        principalTable: "PeriodNumbers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReportSubmitteds_ReportPeriods_ReportPeriodId",
                        column: x => x.ReportPeriodId,
                        principalSchema: "Catalog",
                        principalTable: "ReportPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReportSubmitteds_ReportTemplates_ReportTemplateId",
                        column: x => x.ReportTemplateId,
                        principalSchema: "Catalog",
                        principalTable: "ReportTemplates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportSubmitteds_Code",
                schema: "Catalog",
                table: "ReportSubmitteds",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ReportSubmitteds_PeriodNumberId",
                schema: "Catalog",
                table: "ReportSubmitteds",
                column: "PeriodNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportSubmitteds_ReportPeriodId",
                schema: "Catalog",
                table: "ReportSubmitteds",
                column: "ReportPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportSubmitteds_ReportTemplateId",
                schema: "Catalog",
                table: "ReportSubmitteds",
                column: "ReportTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportSubmitteds",
                schema: "Catalog");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "Catalog",
                table: "Companies");
        }
    }
}
