using Microsoft.EntityFrameworkCore.Migrations;

namespace StatsApp.Migrations
{
    public partial class beta2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "cpm",
                table: "statistics",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(15,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "cpc",
                table: "statistics",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(15,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "cost",
                table: "statistics",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(15,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "cpm",
                table: "statistics",
                type: "numeric(15,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "cpc",
                table: "statistics",
                type: "numeric(15,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "cost",
                table: "statistics",
                type: "numeric(15,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);
        }
    }
}
