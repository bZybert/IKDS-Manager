using Microsoft.EntityFrameworkCore.Migrations;

namespace IKDDS_Manager.Migrations
{
    public partial class AddInvestigationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO InvestigationTypes (Id, Name) VALUES (1, 'RSD')");
            migrationBuilder.Sql("INSERT INTO InvestigationTypes (Id, Name) VALUES (2, 'RPS')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
