using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IKDDS_Manager.Migrations
{
    public partial class AddInvestigationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvestigationTypeId",
                table: "IKDDSModels",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InvestigationType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestigationType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IKDDSModels_InvestigationTypeId",
                table: "IKDDSModels",
                column: "InvestigationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_IKDDSModels_InvestigationType_InvestigationTypeId",
                table: "IKDDSModels",
                column: "InvestigationTypeId",
                principalTable: "InvestigationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IKDDSModels_InvestigationType_InvestigationTypeId",
                table: "IKDDSModels");

            migrationBuilder.DropTable(
                name: "InvestigationType");

            migrationBuilder.DropIndex(
                name: "IX_IKDDSModels_InvestigationTypeId",
                table: "IKDDSModels");

            migrationBuilder.DropColumn(
                name: "InvestigationTypeId",
                table: "IKDDSModels");
        }
    }
}
