﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.AdventureWorks.DbLibrary.Migrations
{
    public partial class UpdateTable_With_EncryptionColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDateBackup",
                schema: "HumanResources",
                table: "Employee",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GenderBackup",
                schema: "HumanResources",
                table: "Employee",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDateBackup",
                schema: "HumanResources",
                table: "Employee",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "JobTitleBackup",
                schema: "HumanResources",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatusBackup",
                schema: "HumanResources",
                table: "Employee",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalIDNumberBackup",
                schema: "HumanResources",
                table: "Employee",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDateBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "GenderBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "HireDateBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobTitleBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MaritalStatusBackup",
                schema: "HumanResources",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "NationalIDNumberBackup",
                schema: "HumanResources",
                table: "Employee");
        }
    }
}
