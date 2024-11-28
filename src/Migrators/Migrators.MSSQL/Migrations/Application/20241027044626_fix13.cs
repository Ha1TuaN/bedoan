using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fix13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportPeriods",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_ReportPeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportTypes",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_ReportTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportUnits",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_ReportUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeriodNumbers",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_PeriodNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriodNumbers_ReportPeriods_ReportPeriodId",
                        column: x => x.ReportPeriodId,
                        principalSchema: "Catalog",
                        principalTable: "ReportPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportTemplates",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    IsGetValue = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDDIUsing = table.Column<bool>(type: "bit", nullable: true),
                    IsFDIUsing = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
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
                    table.PrimaryKey("PK_ReportTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportTemplates_ReportPeriods_ReportPeriodId",
                        column: x => x.ReportPeriodId,
                        principalSchema: "Catalog",
                        principalTable: "ReportPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReportTemplates_ReportTypes_ReportTypeId",
                        column: x => x.ReportTypeId,
                        principalSchema: "Catalog",
                        principalTable: "ReportTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReportMetrics",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MetricType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    IsGetValue = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_ReportMetrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportMetrics_ReportMetrics_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Catalog",
                        principalTable: "ReportMetrics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReportMetrics_ReportUnits_ReportUnitId",
                        column: x => x.ReportUnitId,
                        principalSchema: "Catalog",
                        principalTable: "ReportUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReportDeadlines",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PeriodNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PreviewDeadline = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ReportDeadlines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportDeadlines_PeriodNumbers_PeriodNumberId",
                        column: x => x.PeriodNumberId,
                        principalSchema: "Catalog",
                        principalTable: "PeriodNumbers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReportDeadlines_ReportPeriods_ReportPeriodId",
                        column: x => x.ReportPeriodId,
                        principalSchema: "Catalog",
                        principalTable: "ReportPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReportDeadlines_ReportTemplates_ReportTemplateId",
                        column: x => x.ReportTemplateId,
                        principalSchema: "Catalog",
                        principalTable: "ReportTemplates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeriodNumbers_Name",
                schema: "Catalog",
                table: "PeriodNumbers",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodNumbers_ReportPeriodId",
                schema: "Catalog",
                table: "PeriodNumbers",
                column: "ReportPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDeadlines_PeriodNumberId",
                schema: "Catalog",
                table: "ReportDeadlines",
                column: "PeriodNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDeadlines_ReportPeriodId",
                schema: "Catalog",
                table: "ReportDeadlines",
                column: "ReportPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportDeadlines_ReportTemplateId",
                schema: "Catalog",
                table: "ReportDeadlines",
                column: "ReportTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportMetrics_Code",
                schema: "Catalog",
                table: "ReportMetrics",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ReportMetrics_Name",
                schema: "Catalog",
                table: "ReportMetrics",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ReportMetrics_ParentId",
                schema: "Catalog",
                table: "ReportMetrics",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportMetrics_ReportUnitId",
                schema: "Catalog",
                table: "ReportMetrics",
                column: "ReportUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportPeriods_Code",
                schema: "Catalog",
                table: "ReportPeriods",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ReportPeriods_Name",
                schema: "Catalog",
                table: "ReportPeriods",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTemplates_Code",
                schema: "Catalog",
                table: "ReportTemplates",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTemplates_Name",
                schema: "Catalog",
                table: "ReportTemplates",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTemplates_ReportPeriodId",
                schema: "Catalog",
                table: "ReportTemplates",
                column: "ReportPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTemplates_ReportTypeId",
                schema: "Catalog",
                table: "ReportTemplates",
                column: "ReportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTypes_Code",
                schema: "Catalog",
                table: "ReportTypes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTypes_Name",
                schema: "Catalog",
                table: "ReportTypes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ReportUnits_Code",
                schema: "Catalog",
                table: "ReportUnits",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_ReportUnits_Name",
                schema: "Catalog",
                table: "ReportUnits",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportDeadlines",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportMetrics",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "PeriodNumbers",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportTemplates",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportUnits",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportPeriods",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportTypes",
                schema: "Catalog");
        }
    }
}
