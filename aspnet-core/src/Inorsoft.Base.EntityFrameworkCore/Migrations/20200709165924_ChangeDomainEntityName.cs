using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inorsoft.Base.Migrations
{
    public partial class ChangeDomainEntityName : Migration
    {
        private const string oldDomainsTableName = "TenantDomains";
        private const string newDomainsTableName = "AllowedDomains";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(oldDomainsTableName, newName: newDomainsTableName);

            migrationBuilder.DropIndex($"IX_{oldDomainsTableName}_TenantId", table: newDomainsTableName);
            migrationBuilder.DropPrimaryKey($"PK_{oldDomainsTableName}", newDomainsTableName);
            migrationBuilder.DropForeignKey($"FK_{oldDomainsTableName}_AbpTenants_TenantId", newDomainsTableName);

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                table: newDomainsTableName,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: $"IX_{newDomainsTableName}_TenantId",
                table: newDomainsTableName,
                column: "TenantId");

            migrationBuilder.AddPrimaryKey($"PK_{newDomainsTableName}", newDomainsTableName, "Id");

            migrationBuilder.AddForeignKey(
                        $"FK_{newDomainsTableName}_AbpTenants_TenantId",
                        newDomainsTableName,
                        "TenantId",
                        principalTable: "AbpTenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(newDomainsTableName, newName: oldDomainsTableName);

            migrationBuilder.DropIndex($"IX_{newDomainsTableName}_TenantId", table: oldDomainsTableName);
            migrationBuilder.DropPrimaryKey($"PK_{newDomainsTableName}", oldDomainsTableName);
            migrationBuilder.DropForeignKey($"FK_{newDomainsTableName}_AbpTenants_TenantId", oldDomainsTableName);

            migrationBuilder.AlterColumn<int>(
                name: "TenantId",
                table: oldDomainsTableName,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: $"IX_{oldDomainsTableName}_TenantId",
                table: oldDomainsTableName,
                column: "TenantId");

            migrationBuilder.AddPrimaryKey($"PK_{oldDomainsTableName}", oldDomainsTableName, "Id");

            migrationBuilder.AddForeignKey(
                        $"FK_{oldDomainsTableName}_AbpTenants_TenantId",
                        oldDomainsTableName,
                        "TenantId",
                        principalTable: "AbpTenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
        }
    }
}
