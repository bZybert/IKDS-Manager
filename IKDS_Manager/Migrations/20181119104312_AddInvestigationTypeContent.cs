using Microsoft.EntityFrameworkCore.Migrations;

namespace IKDDS_Manager.Migrations
{
    public partial class AddInvestigationTypeContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT InvestigationType ON");
            migrationBuilder.Sql("INSERT INTO InvestigationType(Id, Type) VALUES (1, 'RPS')");
            migrationBuilder.Sql("INSERT INTO InvestigationType(Id, Type) VALUES (2, 'RSD')");
            migrationBuilder.Sql("SET IDENTITY_INSERT InvestigationType OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
