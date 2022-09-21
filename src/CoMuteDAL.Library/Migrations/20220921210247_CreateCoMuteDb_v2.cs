using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoMuteDAL.Library.Migrations
{
    public partial class CreateCoMuteDb_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_JoinCarPool_CarPoolId",
                table: "JoinCarPool",
                column: "CarPoolId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinCarPool_UserId",
                table: "JoinCarPool",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JoinCarPool_CarPool_CarPoolId",
                table: "JoinCarPool",
                column: "CarPoolId",
                principalTable: "CarPool",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JoinCarPool_User_UserId",
                table: "JoinCarPool",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinCarPool_CarPool_CarPoolId",
                table: "JoinCarPool");

            migrationBuilder.DropForeignKey(
                name: "FK_JoinCarPool_User_UserId",
                table: "JoinCarPool");

            migrationBuilder.DropIndex(
                name: "IX_JoinCarPool_CarPoolId",
                table: "JoinCarPool");

            migrationBuilder.DropIndex(
                name: "IX_JoinCarPool_UserId",
                table: "JoinCarPool");
        }
    }
}
