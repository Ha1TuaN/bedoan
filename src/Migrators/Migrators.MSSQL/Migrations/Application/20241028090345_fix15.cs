using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fix15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableTemplateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JsonData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetricDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableTemplateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JsonData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JsonDataPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JsonDataFromBeginYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JsonDataFromLicensing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetricDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableInTemplates",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportPeriodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionOfData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
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
                    table.PrimaryKey("PK_TableInTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableInTemplates_ReportTemplates_ReportTemplateId",
                        column: x => x.ReportTemplateId,
                        principalSchema: "Catalog",
                        principalTable: "ReportTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetricInTemplates",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TableInTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportMetricId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsRequiredValue = table.Column<bool>(type: "bit", nullable: true),
                    IsGetValue = table.Column<bool>(type: "bit", nullable: true),
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
                    table.PrimaryKey("PK_MetricInTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MetricInTemplates_ReportMetrics_ReportMetricId",
                        column: x => x.ReportMetricId,
                        principalSchema: "Catalog",
                        principalTable: "ReportMetrics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetricInTemplates_ReportTemplates_ReportTemplateId",
                        column: x => x.ReportTemplateId,
                        principalSchema: "Catalog",
                        principalTable: "ReportTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetricInTemplates_TableInTemplates_TableInTemplateId",
                        column: x => x.TableInTemplateId,
                        principalSchema: "Catalog",
                        principalTable: "TableInTemplates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MetricInTemplates_ReportMetricId",
                schema: "Catalog",
                table: "MetricInTemplates",
                column: "ReportMetricId");

            migrationBuilder.CreateIndex(
                name: "IX_MetricInTemplates_ReportTemplateId",
                schema: "Catalog",
                table: "MetricInTemplates",
                column: "ReportTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_MetricInTemplates_TableInTemplateId",
                schema: "Catalog",
                table: "MetricInTemplates",
                column: "TableInTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TableInTemplates_ReportTemplateId",
                schema: "Catalog",
                table: "TableInTemplates",
                column: "ReportTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListDatas");

            migrationBuilder.DropTable(
                name: "MetricDatas");

            migrationBuilder.DropTable(
                name: "MetricInTemplates",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "TableInTemplates",
                schema: "Catalog");
        }
    }
}
