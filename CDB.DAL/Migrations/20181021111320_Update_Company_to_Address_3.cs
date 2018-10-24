using Microsoft.EntityFrameworkCore.Migrations;

namespace CDB.DAL.Migrations
{
    public partial class Update_Company_to_Address_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Address_AddressId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_AddressId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Company");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Company",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_AddressId",
                table: "Company",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Address_AddressId",
                table: "Company",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
