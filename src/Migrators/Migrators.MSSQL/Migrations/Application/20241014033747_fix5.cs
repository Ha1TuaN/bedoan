using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class fix5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutCompanys",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Recruiter = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RecruiterJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTheCompany = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
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
                name: "Recruitments",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Posted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsUrgent = table.Column<bool>(type: "bit", nullable: true),
                    JobPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRequiredGender = table.Column<bool>(type: "bit", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    MaleQuantity = table.Column<int>(type: "int", nullable: true),
                    FemaleQuantity = table.Column<int>(type: "int", nullable: true),
                    WorkingHours = table.Column<int>(type: "int", nullable: true),
                    IsOverTime = table.Column<bool>(type: "bit", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobRequired = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Benefit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentRequired = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Recruiter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecruiterEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTheCompany = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSavedTemplate = table.Column<bool>(type: "bit", nullable: true),
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
                    table.PrimaryKey("PK_Recruitments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recruitments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Catalog",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Recruitments_CompanyId",
                schema: "Catalog",
                table: "Recruitments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Recruitments_Name",
                schema: "Catalog",
                table: "Recruitments",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutCompanys",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Recruitments",
                schema: "Catalog");
        }
    }
}
