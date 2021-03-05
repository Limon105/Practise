using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practise.Migrations
{
    public partial class ModyfyRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Users_UserId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_UserId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Records");

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "Records",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Records_AuthorId",
                table: "Records",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Users_AuthorId",
                table: "Records",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Users_AuthorId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_AuthorId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Records");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Records",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Records_UserId",
                table: "Records",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Users_UserId",
                table: "Records",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
