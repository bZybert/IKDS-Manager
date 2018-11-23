using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IKDDS_Manager.Migrations
{
    public partial class AddNewDbCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedInSystem",
                table: "IKDDSModels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ArticleNumber",
                table: "IKDDSModels",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OZDate",
                table: "IKDDSModels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RealEndDate",
                table: "IKDDSModels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedInSystem",
                table: "IKDDSModels");

            migrationBuilder.DropColumn(
                name: "ArticleNumber",
                table: "IKDDSModels");

            migrationBuilder.DropColumn(
                name: "OZDate",
                table: "IKDDSModels");

            migrationBuilder.DropColumn(
                name: "RealEndDate",
                table: "IKDDSModels");
        }
    }
}
