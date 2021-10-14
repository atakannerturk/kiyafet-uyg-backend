using Microsoft.EntityFrameworkCore.Migrations;

namespace kiyafet_uyg_backend.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total_likes",
                table: "posts",
                newName: "TotalLikes");

            migrationBuilder.RenameColumn(
                name: "Total_dislikes",
                table: "posts",
                newName: "TotalDislikes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalLikes",
                table: "posts",
                newName: "Total_likes");

            migrationBuilder.RenameColumn(
                name: "TotalDislikes",
                table: "posts",
                newName: "Total_dislikes");
        }
    }
}
