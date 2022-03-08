using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.DAL.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOperations_AspNetUsers_ApplicationUserId1",
                table: "ProductOperations");

            migrationBuilder.DropIndex(
                name: "IX_ProductOperations_ApplicationUserId1",
                table: "ProductOperations");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "ProductOperations");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "ProductOperations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOperations_ApplicationUserId",
                table: "ProductOperations",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOperations_AspNetUsers_ApplicationUserId",
                table: "ProductOperations",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOperations_AspNetUsers_ApplicationUserId",
                table: "ProductOperations");

            migrationBuilder.DropIndex(
                name: "IX_ProductOperations_ApplicationUserId",
                table: "ProductOperations");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "ProductOperations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "ProductOperations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductOperations_ApplicationUserId1",
                table: "ProductOperations",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOperations_AspNetUsers_ApplicationUserId1",
                table: "ProductOperations",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
