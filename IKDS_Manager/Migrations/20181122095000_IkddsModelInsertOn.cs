using Microsoft.EntityFrameworkCore.Migrations;

namespace IKDDS_Manager.Migrations
{
    public partial class IkddsModelInsertOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT IKDDSModels ON");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
