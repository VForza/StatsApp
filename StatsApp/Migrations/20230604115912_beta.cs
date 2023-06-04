using Microsoft.EntityFrameworkCore.Migrations;

namespace StatsApp.Migrations
{
    public partial class beta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "cost",
                table: "statistics",
                type: "numeric(15,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(12,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "cpc",
                table: "statistics",
                type: "numeric(15,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "cpm",
                table: "statistics",
                type: "numeric(15,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cpc",
                table: "statistics");

            migrationBuilder.DropColumn(
                name: "cpm",
                table: "statistics");

            migrationBuilder.AlterColumn<decimal>(
                name: "cost",
                table: "statistics",
                type: "numeric(12,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(15,2)",
                oldNullable: true);
        }
    }
}
