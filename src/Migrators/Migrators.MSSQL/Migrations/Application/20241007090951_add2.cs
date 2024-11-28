using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class add2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ParentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    NameWithType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathWithType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
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
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPositions",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
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
                    table.PrimaryKey("PK_JobPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnsignPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCoastalCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Continent = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndustrialParks",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Investor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectProgress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomesticBudgetRegistered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomesticBudgetEquity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomesticBudgetImplemented = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignBudgetRegistered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignBudgetEquity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignBudgetImplemented = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZonedLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClearedLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndustriaLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgriculturalLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConnectionLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrafficLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentalLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnclearedLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccupancyRate = table.Column<int>(type: "int", nullable: true),
                    PlannedOccupancyRate = table.Column<int>(type: "int", nullable: true),
                    RevenueInPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CumulativeRevenue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalRevenue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxPaymentInPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CumulativeTaxPayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTaxPayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomesticLabor = table.Column<int>(type: "int", nullable: true),
                    ForeignLabor = table.Column<int>(type: "int", nullable: true),
                    AreaForWorker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkerArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlannedFloorArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlannedBudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImplementedFloorArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImplementedBudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterTreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterTreatmentPower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterSupplyUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricitSupplyUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelecommunicationSupplyUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPathList = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Companies",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IndustrialParkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateQuantity = table.Column<int>(type: "int", nullable: true),
                    CertificateUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactorRentArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignBudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignBudgetEquity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignBudgetLoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomesticBudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomesticBudgetEquity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomesticBudgetLoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Representative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepresentativePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepresentativeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revenue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExportValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalLabor = table.Column<int>(type: "int", nullable: true),
                    VietnameseLabor = table.Column<int>(type: "int", nullable: true),
                    ForeignLabor = table.Column<int>(type: "int", nullable: true),
                    ConstructionDensity = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "LandPrices",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndustrialParkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LandRentPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryRentPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfrastructureUsageFee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricityUsageFee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterUsageFee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephoneUsageFee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternetUsageFee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentalFee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherRevenue = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Documents",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
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
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WorkMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Name",
                schema: "Catalog",
                table: "Areas",
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
                name: "IX_LandPrices_IndustrialParkId",
                schema: "Catalog",
                table: "LandPrices",
                column: "IndustrialParkId",
                unique: true,
                filter: "[IndustrialParkId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_Name",
                schema: "Catalog",
                table: "Nationalities",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "JobTitles",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "LandPrices",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Nationalities",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Companies",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "JobPositions",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "IndustrialParks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Areas",
                schema: "Catalog");
        }
    }
}
