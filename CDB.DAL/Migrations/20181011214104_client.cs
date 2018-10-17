using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CDB.DAL.Migrations
{
    public partial class client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "CompanyType",
                table: "Client",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AddColumn<bool>(
                name: "Activity",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AuthorizedSignature",
                table: "Client",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "BankName",
                table: "Client",
                maxLength: 100,
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<float>(
                name: "CapitalAmount",
                table: "Client",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "DocsAttached",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstablishDate",
                table: "Client",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FinancialAuditorName",
                table: "Client",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OccupationPermit",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ownership",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNbre",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RealEstateCertificate",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RegistPlaceNumb",
                table: "Client",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ShareHoldersContribution",
                table: "Client",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "ShareHoldersName",
                table: "Client",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShareHoldersPhoneNbre",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShareHoldersPosition",
                table: "Client",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TotalShares",
                table: "Client",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "WorkDuration",
                table: "Client",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activity",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "AuthorizedSignature",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "CapitalAmount",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "DocsAttached",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "EstablishDate",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "FinancialAuditorName",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "OccupationPermit",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Ownership",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "PhoneNbre",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "RealEstateCertificate",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "RegistPlaceNumb",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ShareHoldersContribution",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ShareHoldersName",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ShareHoldersPhoneNbre",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ShareHoldersPosition",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "TotalShares",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "WorkDuration",
                table: "Client");

            migrationBuilder.AlterColumn<short>(
                name: "CompanyType",
                table: "Client",
                nullable: false,
                oldClrType: typeof(byte));
        }
    }
}
