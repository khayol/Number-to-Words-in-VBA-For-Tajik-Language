using Microsoft.EntityFrameworkCore.Migrations;

namespace Woorj.Migrations
{
    public partial class Init_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Language",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Language_StatusId",
                table: "Language",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Language_Status_StatusId",
                table: "Language",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Language_Status_StatusId",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Language_StatusId",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Language");
        }
    }
}
