﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace LeThiChang070.Migrations
{
    public partial class Create_Table_PersonLTC070 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonLTC070",
                columns: table => new
                {
                    PersonID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonLTC070", x => x.PersonID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonLTC070");
        }
    }
}
