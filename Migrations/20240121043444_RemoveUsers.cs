using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HtmxStarter.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_User_UserID",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserID",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Todos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "Todos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserID",
                table: "Todos",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_User_UserID",
                table: "Todos",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID");
        }
    }
}
