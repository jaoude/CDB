using Microsoft.EntityFrameworkCore.Migrations;

namespace CDB.DAL.Migrations
{
    public partial class ADD_LAWYE_AUDITOR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Auditor",
                table: "Company",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AuditorApproval",
                table: "Company",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AuditorProfession",
                table: "Company",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LawyerAuthorization",
                table: "Company",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LawyerId",
                table: "Company",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Auditor",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "AuditorApproval",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "AuditorProfession",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "LawyerAuthorization",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "LawyerId",
                table: "Company");
        }
    }
}
