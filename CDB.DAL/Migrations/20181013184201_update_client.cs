using Microsoft.EntityFrameworkCore.Migrations;

namespace CDB.DAL.Migrations
{
    public partial class update_client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "CityRoad",
                table: "Address",
                newName: "Road");

            migrationBuilder.AddColumn<byte>(
                name: "Bank",
                table: "Client",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Governorate",
                table: "Address",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bank",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Governorate",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "Road",
                table: "Address",
                newName: "CityRoad");

            migrationBuilder.AddColumn<byte>(
                name: "BankName",
                table: "Client",
                maxLength: 100,
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
