using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuraiApp.Data.Migrations
{
    public partial class manytomanysimple_battleid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleSamurai_Battles_BattlesId",
                table: "BattleSamurai");

            migrationBuilder.RenameColumn(
                name: "BattlesId",
                table: "BattleSamurai",
                newName: "BattlesBattleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Battles",
                newName: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleSamurai_Battles_BattlesBattleId",
                table: "BattleSamurai",
                column: "BattlesBattleId",
                principalTable: "Battles",
                principalColumn: "BattleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleSamurai_Battles_BattlesBattleId",
                table: "BattleSamurai");

            migrationBuilder.RenameColumn(
                name: "BattlesBattleId",
                table: "BattleSamurai",
                newName: "BattlesId");

            migrationBuilder.RenameColumn(
                name: "BattleId",
                table: "Battles",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleSamurai_Battles_BattlesId",
                table: "BattleSamurai",
                column: "BattlesId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
