using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Circle.Data.Migrations
{
    public partial class CompanyManagersAndEmployeesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Profile");

            migrationBuilder.CreateTable(
                name: "CompanyManagers",
                schema: "Profile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    VerificationId = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyManagers_Lookups_CityId",
                        column: x => x.CityId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyManagers_Lookups_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyManagers_Lookups_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyManagers_Lookups_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "Profile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    gender = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerificationId = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Lookups_CityId",
                        column: x => x.CityId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Lookups_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Lookups_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyManagers_CityId",
                schema: "Profile",
                table: "CompanyManagers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyManagers_CompanyId",
                schema: "Profile",
                table: "CompanyManagers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyManagers_CountryId",
                schema: "Profile",
                table: "CompanyManagers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyManagers_TypeId",
                schema: "Profile",
                table: "CompanyManagers",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CityId",
                schema: "Profile",
                table: "Employees",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId",
                schema: "Profile",
                table: "Employees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TypeId",
                schema: "Profile",
                table: "Employees",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyManagers",
                schema: "Profile");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "Profile");
        }
    }
}
