using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class renthomev1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryGroups_CategoryGroupId",
                schema: "Catalog",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_OrganizationUnits_OrganizationUnitId",
                schema: "Identity",
                table: "Users");

            migrationBuilder.DropTable(
                name: "AboutCompanys",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "BuildingItems",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "CategoryGroups",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Documents",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "InvestmentCertificates",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "IPEnvironments",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "IPResources",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "JobTitles",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "LaborAgreements",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "LandPrices",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ListDatas",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "MetricDatas",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "MetricInTemplates",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "OvertimeRegisters",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Recruitments",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "RegulaRegisters",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportDeadlines",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportSubmitteds",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Trainings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "WorkerPassports",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "WorkerVisas",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "WorkPermits",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "BuildingPermits",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportMetrics",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "TableInTemplates",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "PeriodNumbers",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Workers",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "InvestmentProjects",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportUnits",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportTemplates",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Companies",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "JobPositions",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Nationalities",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportPeriods",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ReportTypes",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "IndustrialParks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "OrganizationUnits",
                schema: "Catalog");

            migrationBuilder.DropIndex(
                name: "IX_Users_OrganizationUnitId",
                schema: "Identity",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryGroupId",
                schema: "Catalog",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_AttachmentTypes_Name",
                table: "AttachmentTypes");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                schema: "Identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                schema: "Identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrganizationUnitId",
                schema: "Identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "AttachmentTypes");

            migrationBuilder.EnsureSchema(
                name: "House");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AttachmentTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AttachmentTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "AttachmentTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Motels",
                schema: "House",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Star = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Area = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BedroomCount = table.Column<int>(type: "int", nullable: true),
                    BathroomCount = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Motels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motels_Areas_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Motels_Areas_ProvinceId",
                        column: x => x.ProvinceId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Motels_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "Catalog",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatureHouses",
                schema: "House",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_FeatureHouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeatureHouses_Motels_MotelId",
                        column: x => x.MotelId,
                        principalSchema: "House",
                        principalTable: "Motels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageHouses",
                schema: "House",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ImageHouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageHouses_Motels_MotelId",
                        column: x => x.MotelId,
                        principalSchema: "House",
                        principalTable: "Motels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureHouses_MotelId",
                schema: "House",
                table: "FeatureHouses",
                column: "MotelId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageHouses_MotelId",
                schema: "House",
                table: "ImageHouses",
                column: "MotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Motels_CategoryId",
                schema: "House",
                table: "Motels",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Motels_DistrictId",
                schema: "House",
                table: "Motels",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Motels_ProvinceId",
                schema: "House",
                table: "Motels",
                column: "ProvinceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureHouses",
                schema: "House");

            migrationBuilder.DropTable(
                name: "ImageHouses",
                schema: "House");

            migrationBuilder.DropTable(
                name: "Motels",
                schema: "House");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                schema: "Identity",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                schema: "Identity",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OrganizationUnitId",
                schema: "Identity",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AttachmentTypes",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AttachmentTypes",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "AttachmentTypes",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "AttachmentTypes",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CategoryGroups",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsSystem = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndustrialParks",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgriculturalLand = table.Column<int>(type: "int", nullable: true),
                    AreaForWorker = table.Column<int>(type: "int", nullable: true),
                    AvatarPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClearedLand = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConnectionLand = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CumulativeRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CumulativeTaxPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DomesticBudgetEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticBudgetImplemented = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticBudgetRegistered = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticLabor = table.Column<int>(type: "int", nullable: true),
                    ElectricitSupplyUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignBudgetEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ForeignBudgetImplemented = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ForeignBudgetRegistered = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ForeignLabor = table.Column<int>(type: "int", nullable: true),
                    ImplementedBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImplementedFloorArea = table.Column<int>(type: "int", nullable: true),
                    IndustriaLand = table.Column<int>(type: "int", nullable: true),
                    Investor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    OccupancyRate = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPathList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlannedBudget = table.Column<int>(type: "int", nullable: true),
                    PlannedFloorArea = table.Column<int>(type: "int", nullable: true),
                    PlannedOccupancyRate = table.Column<int>(type: "int", nullable: true),
                    ProjectProgress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentalLand = table.Column<int>(type: "int", nullable: true),
                    RevenueInPeriod = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxPaymentInPeriod = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TelecommunicationSupplyUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TotalRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalTaxPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrafficLand = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnclearedLand = table.Column<int>(type: "int", nullable: true),
                    WaterSupplyUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterTreatmentPower = table.Column<int>(type: "int", nullable: true),
                    WaterTreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkerArea = table.Column<int>(type: "int", nullable: true),
                    ZonedLand = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustrialParks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustrialParks_Areas_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialParks_Areas_ProvinceId",
                        column: x => x.ProvinceId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialParks_Areas_WardId",
                        column: x => x.WardId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InvestmentProjects",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActualStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditedAttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditedContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingScope = table.Column<int>(type: "int", nullable: true),
                    Challenge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DecisionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DesignCapability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExecutionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundingNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundingSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsAudited = table.Column<bool>(type: "bit", nullable: true),
                    IsHasBuilding = table.Column<bool>(type: "bit", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssuingAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandCleanStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlannedStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgressStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TotalInvestment = table.Column<int>(type: "int", nullable: true),
                    TypeOfStructure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfUsage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestmentProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvestmentProjects_Areas_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvestmentProjects_Areas_ProvinceId",
                        column: x => x.ProvinceId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvestmentProjects_Areas_WardId",
                        column: x => x.WardId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobPositions",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListDatas",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JsonData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableTemplateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetricDatas",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JsonData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JsonDataFromBeginYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JsonDataFromLicensing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JsonDataPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableTemplateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetricDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Continent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnsignPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCoastalCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationUnits",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MainTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ShortcutName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationUnits_OrganizationUnits_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Catalog",
                        principalTable: "OrganizationUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReportPeriods",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandPrices",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndustrialParkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ElectricityUsageFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EnvironmentalFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FactoryRentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InfrastructureUsageFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InternetUsageFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LandRentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OtherRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TelephoneUsageFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    WaterUsageFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandPrices_IndustrialParks_IndustrialParkId",
                        column: x => x.IndustrialParkId,
                        principalSchema: "Catalog",
                        principalTable: "IndustrialParks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IndustrialParkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrganizationUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AvatarPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateQuantity = table.Column<int>(type: "int", nullable: true),
                    CertificateUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ConstructionDensity = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DomesticBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticBudgetEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticBudgetLoan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FactorRentArea = table.Column<int>(type: "int", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ForeignBudgetEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ForeignBudgetLoan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ForeignLabor = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Representative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepresentativeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepresentativePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revenue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TotalLabor = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VietnameseLabor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Areas_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companies_Areas_ProvinceId",
                        column: x => x.ProvinceId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companies_Areas_WardId",
                        column: x => x.WardId,
                        principalSchema: "Catalog",
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companies_IndustrialParks_IndustrialParkId",
                        column: x => x.IndustrialParkId,
                        principalSchema: "Catalog",
                        principalTable: "IndustrialParks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companies_OrganizationUnits_OrganizationUnitId",
                        column: x => x.OrganizationUnitId,
                        principalSchema: "Catalog",
                        principalTable: "OrganizationUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PeriodNumbers",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsGetValue = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    UsingForCompany = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsGetValue = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MetricType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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
                name: "AboutCompanys",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AboutTheCompany = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recruiter = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RecruiterEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutCompanys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutCompanys_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildingPermits",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InvestmentProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BPNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    BuildingBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingSetbackLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OtherContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlotAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlotArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingPermits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingPermits_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BuildingPermits_InvestmentProjects_InvestmentProjectId",
                        column: x => x.InvestmentProjectId,
                        principalSchema: "Catalog",
                        principalTable: "InvestmentProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InvestmentCertificates",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActiveDuration = table.Column<int>(type: "int", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DomesticBudgetEquity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticBudgetImplemented = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DomesticBudgetRegistered = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FactoryRentArea = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FactoryRentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ICNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Investor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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

            migrationBuilder.CreateTable(
                name: "IPResources",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IndustrialParkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CertificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificatePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmedDocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GrantDecision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrantDecisionPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrtherDocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmitedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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

            migrationBuilder.CreateTable(
                name: "JobTitles",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobPositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    WorkMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTitles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobTitles_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalSchema: "Catalog",
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LaborAgreements",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgreementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AgreementType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgreementValid = table.Column<int>(type: "int", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReasonReject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaborAgreements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaborAgreements_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OvertimeRegisters",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageTotal = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReasonReject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecicalCase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    WorkerQuantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OvertimeRegisters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OvertimeRegisters_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recruitments",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AboutTheCompany = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Benefit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentRequired = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FemaleQuantity = table.Column<int>(type: "int", nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOverTime = table.Column<bool>(type: "bit", nullable: true),
                    IsRequiredGender = table.Column<bool>(type: "bit", nullable: true),
                    IsSavedTemplate = table.Column<bool>(type: "bit", nullable: true),
                    IsUrgent = table.Column<bool>(type: "bit", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobRequired = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaleQuantity = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Recruiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    WorkingHours = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruitments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recruitments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegulaRegisters",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReasonReject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegisterResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegulaRegisters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegulaRegisters_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DecisionNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobPositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NationalityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    WPNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id");
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
                name: "WorkPermits",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobPositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NationalityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AvatarPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExemptCase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsUsePositon = table.Column<bool>(type: "bit", nullable: true),
                    IssuanceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NameUseWorker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldWPNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PassportExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportIssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PassportPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPathList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonReject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportCase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    WPIssuingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WPIssuingUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WPNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    WorkMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPurpose = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPermits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPermits_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkPermits_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalSchema: "Catalog",
                        principalTable: "JobPositions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkPermits_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalSchema: "Catalog",
                        principalTable: "Nationalities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IPEnvironments",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IndustrialParkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PeriodNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConfirmedDocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DecisionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmissionComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissionTreatmentResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissionTreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmissionTreatmentUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentalPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentalPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentalStaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MonitoringUnitFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitoringUnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitoringUnitPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitoringUnitPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyEmission = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MonthlySolidWaste = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MonthlyWastewater = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RecordName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportYear = table.Column<int>(type: "int", nullable: true),
                    SampleCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SampleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SamplingTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SixMonthEmission = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SixMonthSolidWaste = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SixMonthWastewater = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SolidWasteComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolidWasteTreatmentResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolidWasteTreatmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolidWasteTreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolidWasteTreatmentUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusAssessment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmitedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    TestingTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalEmission = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalSolidWaste = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalWastewater = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalWater = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WastewaterComposition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterConnection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterTreatmentResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterTreatmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterTreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastewaterTreatmentUnit = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "ReportDeadlines",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PeriodNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PreviewDeadline = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ReportSubmitteds",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PeriodNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentScan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportYear = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "TableInTemplates",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionOfData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportPeriodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TableType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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
                name: "BuildingItems",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingPermitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BuildingHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BuiltArea = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FloorArea = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NumberOfFloor = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingItems_BuildingPermits_BuildingPermitId",
                        column: x => x.BuildingPermitId,
                        principalSchema: "Catalog",
                        principalTable: "BuildingPermits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkerPassports",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportIssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PassportPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    VisaExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VisaIssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VisaNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VisaPlace = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    VisaType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
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

            migrationBuilder.CreateTable(
                name: "MetricInTemplates",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportMetricId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReportTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TableInTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsGetValue = table.Column<bool>(type: "bit", nullable: true),
                    IsRequiredValue = table.Column<bool>(type: "bit", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
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
                name: "IX_Users_OrganizationUnitId",
                schema: "Identity",
                table: "Users",
                column: "OrganizationUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryGroupId",
                schema: "Catalog",
                table: "Categories",
                column: "CategoryGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentTypes_Name",
                table: "AttachmentTypes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AboutCompanys_CompanyId",
                schema: "Catalog",
                table: "AboutCompanys",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutCompanys_Recruiter",
                schema: "Catalog",
                table: "AboutCompanys",
                column: "Recruiter");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingItems_BuildingPermitId",
                schema: "Catalog",
                table: "BuildingItems",
                column: "BuildingPermitId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingItems_Name",
                schema: "Catalog",
                table: "BuildingItems",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingPermits_BPNumber",
                schema: "Catalog",
                table: "BuildingPermits",
                column: "BPNumber");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingPermits_CompanyId",
                schema: "Catalog",
                table: "BuildingPermits",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingPermits_InvestmentProjectId",
                schema: "Catalog",
                table: "BuildingPermits",
                column: "InvestmentProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryGroups_Name",
                schema: "Catalog",
                table: "CategoryGroups",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DistrictId",
                schema: "Catalog",
                table: "Companies",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IndustrialParkId",
                schema: "Catalog",
                table: "Companies",
                column: "IndustrialParkId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Name",
                schema: "Catalog",
                table: "Companies",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_OrganizationUnitId",
                schema: "Catalog",
                table: "Companies",
                column: "OrganizationUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProvinceId",
                schema: "Catalog",
                table: "Companies",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_WardId",
                schema: "Catalog",
                table: "Companies",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_CompanyId",
                schema: "Catalog",
                table: "Documents",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentNumber",
                schema: "Catalog",
                table: "Documents",
                column: "DocumentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialParks_DistrictId",
                schema: "Catalog",
                table: "IndustrialParks",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialParks_Name",
                schema: "Catalog",
                table: "IndustrialParks",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialParks_ProvinceId",
                schema: "Catalog",
                table: "IndustrialParks",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialParks_WardId",
                schema: "Catalog",
                table: "IndustrialParks",
                column: "WardId");

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

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentProjects_DistrictId",
                schema: "Catalog",
                table: "InvestmentProjects",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentProjects_Name",
                schema: "Catalog",
                table: "InvestmentProjects",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentProjects_ProvinceId",
                schema: "Catalog",
                table: "InvestmentProjects",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentProjects_WardId",
                schema: "Catalog",
                table: "InvestmentProjects",
                column: "WardId");

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

            migrationBuilder.CreateIndex(
                name: "IX_JobPositions_Name",
                schema: "Catalog",
                table: "JobPositions",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_CompanyId",
                schema: "Catalog",
                table: "JobTitles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_JobPositionId",
                schema: "Catalog",
                table: "JobTitles",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_Name",
                schema: "Catalog",
                table: "JobTitles",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_LaborAgreements_CompanyId",
                schema: "Catalog",
                table: "LaborAgreements",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_LandPrices_IndustrialParkId",
                schema: "Catalog",
                table: "LandPrices",
                column: "IndustrialParkId",
                unique: true,
                filter: "[IndustrialParkId] IS NOT NULL");

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
                name: "IX_Nationalities_Name",
                schema: "Catalog",
                table: "Nationalities",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUnits_Name",
                schema: "Catalog",
                table: "OrganizationUnits",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUnits_ParentId",
                schema: "Catalog",
                table: "OrganizationUnits",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_OvertimeRegisters_CompanyId",
                schema: "Catalog",
                table: "OvertimeRegisters",
                column: "CompanyId");

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
                name: "IX_Recruitments_CompanyId",
                schema: "Catalog",
                table: "Recruitments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Recruitments_Name",
                schema: "Catalog",
                table: "Recruitments",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_RegulaRegisters_CompanyId",
                schema: "Catalog",
                table: "RegulaRegisters",
                column: "CompanyId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TableInTemplates_ReportTemplateId",
                schema: "Catalog",
                table: "TableInTemplates",
                column: "ReportTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_CompanyId",
                schema: "Catalog",
                table: "Trainings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_DecisionNumber",
                schema: "Catalog",
                table: "Trainings",
                column: "DecisionNumber");

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
                name: "IX_Workers_CompanyId",
                schema: "Catalog",
                table: "Workers",
                column: "CompanyId");

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

            migrationBuilder.CreateIndex(
                name: "IX_WorkPermits_CompanyId",
                schema: "Catalog",
                table: "WorkPermits",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPermits_FullName",
                schema: "Catalog",
                table: "WorkPermits",
                column: "FullName");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPermits_JobPositionId",
                schema: "Catalog",
                table: "WorkPermits",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPermits_NationalityId",
                schema: "Catalog",
                table: "WorkPermits",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPermits_OldWPNumber",
                schema: "Catalog",
                table: "WorkPermits",
                column: "OldWPNumber");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPermits_PassportNumber",
                schema: "Catalog",
                table: "WorkPermits",
                column: "PassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPermits_WPNumber",
                schema: "Catalog",
                table: "WorkPermits",
                column: "WPNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryGroups_CategoryGroupId",
                schema: "Catalog",
                table: "Categories",
                column: "CategoryGroupId",
                principalSchema: "Catalog",
                principalTable: "CategoryGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_OrganizationUnits_OrganizationUnitId",
                schema: "Identity",
                table: "Users",
                column: "OrganizationUnitId",
                principalSchema: "Catalog",
                principalTable: "OrganizationUnits",
                principalColumn: "Id");
        }
    }
}
