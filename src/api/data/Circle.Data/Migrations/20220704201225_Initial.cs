using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Circle.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Foundation");

            migrationBuilder.EnsureSchema(
                name: "Associate");

            migrationBuilder.EnsureSchema(
                name: "Usage");

            migrationBuilder.EnsureSchema(
                name: "Main");

            migrationBuilder.EnsureSchema(
                name: "Profile");

            migrationBuilder.CreateTable(
                name: "Companies",
                schema: "Foundation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LookupTypes",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lookups",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lookups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lookups_Lookups_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lookups_LookupTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "Main",
                        principalTable: "LookupTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Profile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    VerificationId = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Lookups_CityId",
                        column: x => x.CityId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Lookups_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyUsers",
                schema: "Associate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Foundation",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyUsers_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Profile",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Debits",
                schema: "Usage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DebitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debits_Lookups_DebitTypeId",
                        column: x => x.DebitTypeId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Debits_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Profile",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permits",
                schema: "Usage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permits_Lookups_PermitTypeId",
                        column: x => x.PermitTypeId,
                        principalSchema: "Main",
                        principalTable: "Lookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permits_Users_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "Profile",
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Permits_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Profile",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_CompanyId",
                schema: "Associate",
                table: "CompanyUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_UserId",
                schema: "Associate",
                table: "CompanyUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_DebitTypeId",
                schema: "Usage",
                table: "Debits",
                column: "DebitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Debits_UserId",
                schema: "Usage",
                table: "Debits",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lookups_ParentId",
                schema: "Main",
                table: "Lookups",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lookups_TypeId",
                schema: "Main",
                table: "Lookups",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permits_ManagerId",
                schema: "Usage",
                table: "Permits",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Permits_PermitTypeId",
                schema: "Usage",
                table: "Permits",
                column: "PermitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permits_UserId",
                schema: "Usage",
                table: "Permits",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                schema: "Profile",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                schema: "Profile",
                table: "Users",
                column: "CountryId");
            migrationBuilder.MigrateUsers();
            migrationBuilder.MigrateLookups();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyUsers",
                schema: "Associate");

            migrationBuilder.DropTable(
                name: "Debits",
                schema: "Usage");

            migrationBuilder.DropTable(
                name: "Permits",
                schema: "Usage");

            migrationBuilder.DropTable(
                name: "Companies",
                schema: "Foundation");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Profile");

            migrationBuilder.DropTable(
                name: "Lookups",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "LookupTypes",
                schema: "Main");
        }
    }
}
