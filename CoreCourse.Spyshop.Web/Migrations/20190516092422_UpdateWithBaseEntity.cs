using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCourse.Spyshop.Web.Migrations
{
    public partial class UpdateWithBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUsername",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeCreated",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeDeleted",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeLastUpdated",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUsername",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByUsername",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUsername",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeCreated",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeDeleted",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeLastUpdated",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUsername",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByUsername",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUsername",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateTimeCreated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateTimeDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateTimeLastUpdated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedByUsername",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUsername",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedByUsername",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DateTimeCreated",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DateTimeDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DateTimeLastUpdated",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletedByUsername",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUsername",
                table: "Categories");
        }
    }
}
