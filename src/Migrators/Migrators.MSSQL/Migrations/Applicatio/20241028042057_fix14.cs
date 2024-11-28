using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Applicatio
{
    /// <inheritdoc />
    public partial class fix14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDDIUsing",
                schema: "Catalog",
                table: "ReportTemplates");

            migrationBuilder.DropColumn(
                name: "IsFDIUsing",
                schema: "Catalog",
                table: "ReportTemplates");

            migrationBuilder.AddColumn<string>(
                name: "UsingForCompany",
                schema: "Catalog",
                table: "ReportTemplates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Workers",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WPNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NationalityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobPositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobTitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_Workers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workers_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalSchema: "Catalog",
                        principalTable: "JobPositions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Workers_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalSchema: "Catalog",
                        principalTable: "Nationalities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkerPassports",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PassportIssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_WorkerPassports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkerPassports_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalSchema: "Catalog",
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkerVisas",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VisaNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VisaType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VisaIssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VisaExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VisaPlace = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_WorkerVisas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkerVisas_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalSchema: "Catalog",
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerPassports_PassportNumber",
                schema: "Catalog",
                table: "WorkerPassports",
                column: "PassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerPassports_WorkerId",
                schema: "Catalog",
                table: "WorkerPassports",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_FullName",
                schema: "Catalog",
                table: "Workers",
                column: "FullName");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_JobPositionId",
                schema: "Catalog",
                table: "Workers",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_NationalityId",
                schema: "Catalog",
                table: "Workers",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_WPNumber",
                schema: "Catalog",
                table: "Workers",
                column: "WPNumber");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerVisas_VisaNumber",
                schema: "Catalog",
                table: "WorkerVisas",
                column: "VisaNumber");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerVisas_VisaType",
                schema: "Catalog",
                table: "WorkerVisas",
                column: "VisaType");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerVisas_WorkerId",
                schema: "Catalog",
                table: "WorkerVisas",
                column: "WorkerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkerPassports",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "WorkerVisas",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Workers",
                schema: "Catalog");

            migrationBuilder.DropColumn(
                name: "UsingForCompany",
                schema: "Catalog",
                table: "ReportTemplates");

            migrationBuilder.AddColumn<bool>(
                name: "IsDDIUsing",
                schema: "Catalog",
                table: "ReportTemplates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFDIUsing",
                schema: "Catalog",
                table: "ReportTemplates",
                type: "bit",
                nullable: true);
        }
    }
}
