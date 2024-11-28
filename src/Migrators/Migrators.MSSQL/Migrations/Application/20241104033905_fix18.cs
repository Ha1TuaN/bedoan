using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fix18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IPEnvironments",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndustrialParkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubmitedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PeriodNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportYear = table.Column<int>(type: "int", nullable: true),
                    EnvironmentalStaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentalPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitoringUnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitoringUnitPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitoringUnitPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitoringUnitFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SampleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SampleCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SamplingTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestingTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecisionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecordName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusAssessment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmedDocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalWater = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MonthlyWastewater = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SixMonthWastewater = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalWastewater = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WastewaterComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterTreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterTreatmentUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterTreatmentResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterConnection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterTreatmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalEmission = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MonthlyEmission = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SixMonthEmission = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EmissionComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissionTreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissionTreatmentUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissionTreatmentResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSolidWaste = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MonthlySolidWaste = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SixMonthSolidWaste = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SolidWasteComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolidWasteTreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolidWasteTreatmentUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolidWasteTreatmentResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolidWasteTreatmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_IPEnvironments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPEnvironments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPEnvironments_IndustrialParks_IndustrialParkId",
                        column: x => x.IndustrialParkId,
                        principalSchema: "Catalog",
                        principalTable: "IndustrialParks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IPEnvironments_PeriodNumbers_PeriodNumberId",
                        column: x => x.PeriodNumberId,
                        principalSchema: "Catalog",
                        principalTable: "PeriodNumbers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IPEnvironments_ReportPeriods_ReportPeriodId",
                        column: x => x.ReportPeriodId,
                        principalSchema: "Catalog",
                        principalTable: "ReportPeriods",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IPResources",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndustrialParkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubmitedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrantDecision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificatePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrantDecisionPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmedDocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrtherDocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_IPResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPResources_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPResources_IndustrialParks_IndustrialParkId",
                        column: x => x.IndustrialParkId,
                        principalSchema: "Catalog",
                        principalTable: "IndustrialParks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IPEnvironments_CompanyId",
                schema: "Catalog",
                table: "IPEnvironments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_IPEnvironments_IndustrialParkId",
                schema: "Catalog",
                table: "IPEnvironments",
                column: "IndustrialParkId");

            migrationBuilder.CreateIndex(
                name: "IX_IPEnvironments_PeriodNumberId",
                schema: "Catalog",
                table: "IPEnvironments",
                column: "PeriodNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_IPEnvironments_ReportPeriodId",
                schema: "Catalog",
                table: "IPEnvironments",
                column: "ReportPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_IPResources_CompanyId",
                schema: "Catalog",
                table: "IPResources",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_IPResources_IndustrialParkId",
                schema: "Catalog",
                table: "IPResources",
                column: "IndustrialParkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IPEnvironments",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "IPResources",
                schema: "Catalog");
        }
    }
}
