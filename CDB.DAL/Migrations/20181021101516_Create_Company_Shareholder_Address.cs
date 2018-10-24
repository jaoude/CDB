using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CDB.DAL.Migrations
{
    public partial class Create_Company_Shareholder_Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Kaza = table.Column<byte>(nullable: false),
                    District = table.Column<byte>(nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    Road = table.Column<string>(maxLength: 100, nullable: true),
                    Building = table.Column<string>(maxLength: 100, nullable: true),
                    Floor = table.Column<string>(maxLength: 100, nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<string>(maxLength: 12, nullable: true),
                    CompanyName = table.Column<string>(maxLength: 100, nullable: true),
                    ArabicCompanyName = table.Column<string>(maxLength: 100, nullable: true),
                    CompanyType = table.Column<byte>(nullable: false),
                    AddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shareholder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 8, nullable: true),
                    ShareContribution = table.Column<decimal>(type: "decimal(19, 4)", nullable: false),
                    FinancialNumber = table.Column<string>(maxLength: 100, nullable: true),
                    PlaceAndDateOfBirth = table.Column<string>(maxLength: 100, nullable: true),
                    Nationality = table.Column<string>(maxLength: 100, nullable: true),
                    ProcuratorName = table.Column<string>(maxLength: 100, nullable: true),
                    SigningThrough = table.Column<byte>(nullable: false),
                    ShareHolderIdAttached = table.Column<bool>(nullable: false),
                    ProcurationAttached = table.Column<bool>(nullable: false),
                    AddressId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shareholder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shareholder_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shareholder_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_AddressId",
                table: "Company",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Shareholder_AddressId",
                table: "Shareholder",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Shareholder_CompanyId",
                table: "Shareholder",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shareholder");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
