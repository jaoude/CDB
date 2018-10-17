using Microsoft.EntityFrameworkCore.Migrations;

namespace CDB.DAL.Migrations
{
    public partial class client_update_money : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalAmount",
                table: "Client",
                type: "decimal(19, 4)",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "CapitalAmount",
                table: "Client",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(19, 4)");
        }
    }
}
