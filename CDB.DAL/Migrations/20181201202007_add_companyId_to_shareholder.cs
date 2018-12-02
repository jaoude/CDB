using Microsoft.EntityFrameworkCore.Migrations;

namespace CDB.DAL.Migrations
{
    public partial class add_companyId_to_shareholder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shareholder_Company_CompanyId",
                table: "Shareholder");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Shareholder",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Shareholder_Company_CompanyId",
                table: "Shareholder",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shareholder_Company_CompanyId",
                table: "Shareholder");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Shareholder",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Shareholder_Company_CompanyId",
                table: "Shareholder",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
