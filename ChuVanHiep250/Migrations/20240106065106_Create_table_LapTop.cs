using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChuVanHiep250.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_LapTop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LapTop",
                columns: table => new
                {
                    TenLapTop = table.Column<string>(type: "TEXT", nullable: false),
                    NgayMua = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GiaTien = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LapTop", x => x.TenLapTop);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LapTop");
        }
    }
}
