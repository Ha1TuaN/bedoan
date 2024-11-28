using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fix7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePersonalId",
                schema: "Identity",
                table: "Users",
                newName: "CompanyId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "Identity",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                schema: "Identity",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                schema: "Identity",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InvestmentProjects",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Investor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsHasBuilding = table.Column<bool>(type: "bit", nullable: true),
                    DesignCapability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingScope = table.Column<int>(type: "int", nullable: true),
                    BuildingLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandCleanStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfUsage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfStructure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Challenge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlannedStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgressStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecutionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAudited = table.Column<bool>(type: "bit", nullable: true),
                    AuditedContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditedAttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecisionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuingAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundingSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundingNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalInvestment = table.Column<int>(type: "int", nullable: true),
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
                name: "Trainings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DecisionNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "BuildingPermits",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InvestmentProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BPNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlotAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlotArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingSetbackLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
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
                name: "BuildingItems",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingPermitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    BuiltArea = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FloorArea = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NumberOfFloor = table.Column<int>(type: "int", nullable: true),
                    BuildingHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    table.PrimaryKey("PK_BuildingItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingItems_BuildingPermits_BuildingPermitId",
                        column: x => x.BuildingPermitId,
                        principalSchema: "Catalog",
                        principalTable: "BuildingPermits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Trainings_CompanyId",
                schema: "Catalog",
                table: "Trainings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_DecisionNumber",
                schema: "Catalog",
                table: "Trainings",
                column: "DecisionNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingItems",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Trainings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "BuildingPermits",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "InvestmentProjects",
                schema: "Catalog");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "Identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                schema: "Identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Type",
                schema: "Identity",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                schema: "Identity",
                table: "Users",
                newName: "ProfilePersonalId");
        }
    }
}
