using Microsoft.EntityFrameworkCore.Migrations;

namespace IKDDS_Manager.Migrations
{
    public partial class AddInvestigationInitiationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT InvestigationInitiateTypes ON");
            migrationBuilder.Sql("INSERT INTO InvestigationInitiateTypes (Id, Name) VALUES (1, 'Wszczęcie postępowania')");
            migrationBuilder.Sql("INSERT INTO InvestigationInitiateTypes (Id, Name) VALUES (2, 'Odmowa wszczęcia')");
            migrationBuilder.Sql("INSERT INTO InvestigationInitiateTypes (Id, Name) VALUES (3, 'Zwrot z prokuratury')");
            migrationBuilder.Sql("INSERT INTO InvestigationInitiateTypes (Id, Name) VALUES (4, 'Przedłużenie terminu')");
            migrationBuilder.Sql("INSERT INTO InvestigationInitiateTypes (Id, Name) VALUES (5, 'Zakończono')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
