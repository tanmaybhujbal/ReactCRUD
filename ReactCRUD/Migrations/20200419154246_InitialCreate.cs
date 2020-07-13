﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactCRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCandidates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    mobile = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    age = table.Column<int>(nullable: false),
                    bloodgroup = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCandidates", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCandidates");
        }
    }
}