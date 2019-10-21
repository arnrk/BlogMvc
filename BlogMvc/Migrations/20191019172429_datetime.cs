using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMvc.Migrations
{
    public partial class datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Post",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 10, 19, 13, 24, 28, 979, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 10, 19, 13, 24, 28, 981, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 10, 19, 13, 24, 28, 981, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 10, 19, 13, 24, 28, 981, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Post");
        }
    }
}
