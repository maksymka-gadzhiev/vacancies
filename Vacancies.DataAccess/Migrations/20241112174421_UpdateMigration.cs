using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vacancies.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Vacancies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ExternalId",
                table: "Vacancies",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationTime",
                table: "Vacancies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Resumes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ExternalId",
                table: "Resumes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationTime",
                table: "Resumes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Responses",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ExternalId",
                table: "Responses",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationTime",
                table: "Responses",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Employers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ExternalId",
                table: "Employers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationTime",
                table: "Employers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Applicants",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ExternalId",
                table: "Applicants",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationTime",
                table: "Applicants",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "ModificationTime",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ModificationTime",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "ModificationTime",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "ModificationTime",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "ModificationTime",
                table: "Applicants");
        }
    }
}
