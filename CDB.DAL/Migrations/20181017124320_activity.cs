using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CDB.DAL.Migrations
{
    public partial class activity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BldgFloor",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Road",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "district",
                table: "Address",
                newName: "AdressKaza");

            migrationBuilder.RenameColumn(
                name: "Governorate",
                table: "Address",
                newName: "AdressGovernate");

            migrationBuilder.AlterColumn<string>(
                name: "WorkDuration",
                table: "Client",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<double>(
                name: "ShareHoldersPhoneNbre",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PhoneNbre",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocsAttached",
                table: "Client",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Activity",
                table: "Client",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<bool>(
                name: "Activity1",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activity2",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activity3",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activity4",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activity5",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activity6",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activity7",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Docs1Attached",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Docs2Attached",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LawyerName",
                table: "Client",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OccupationDeed",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Rental",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AddressBldg",
                table: "Address",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressCity",
                table: "Address",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressCompany",
                table: "Address",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activity1",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Activity2",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Activity3",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Activity4",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Activity5",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Activity6",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Activity7",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Docs1Attached",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Docs2Attached",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "LawyerName",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "OccupationDeed",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Rental",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "AddressBldg",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AddressCity",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AddressCompany",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "AdressKaza",
                table: "Address",
                newName: "district");

            migrationBuilder.RenameColumn(
                name: "AdressGovernate",
                table: "Address",
                newName: "Governorate");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "WorkDuration",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShareHoldersPhoneNbre",
                table: "Client",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNbre",
                table: "Client",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<bool>(
                name: "DocsAttached",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Activity",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BldgFloor",
                table: "Address",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Address",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Road",
                table: "Address",
                nullable: true);
        }
    }
}
