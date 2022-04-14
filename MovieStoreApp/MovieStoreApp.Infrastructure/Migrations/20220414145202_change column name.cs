using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieStoreApp.Infrastructure.Migrations
{
    public partial class changecolumnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titile",
                table: "Movie",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Bugget",
                table: "Movie",
                newName: "Budget");

            migrationBuilder.AlterColumn<string>(
                name: "Overview",
                table: "Movie",
                type: "Varchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(120)",
                oldMaxLength: 120);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movie",
                newName: "Titile");

            migrationBuilder.RenameColumn(
                name: "Budget",
                table: "Movie",
                newName: "Bugget");

            migrationBuilder.AlterColumn<string>(
                name: "Overview",
                table: "Movie",
                type: "Varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(1000)",
                oldMaxLength: 1000);
        }
    }
}
