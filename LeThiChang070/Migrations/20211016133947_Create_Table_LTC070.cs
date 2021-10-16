using Microsoft.EntityFrameworkCore.Migrations;

namespace LeThiChang070.Migrations
{
    public partial class Create_Table_LTC070 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LTC070",
                columns: table => new
                {
                    LTCID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LTCName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LTCGender = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LTC070", x => x.LTCID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LTC070");
        }
    }
}
