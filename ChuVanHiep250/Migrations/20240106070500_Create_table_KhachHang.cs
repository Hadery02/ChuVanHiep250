using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChuVanHiep250.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_KhachHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khach Hang",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenKhachHang = table.Column<string>(type: "TEXT", nullable: false),
                    TenLapTop = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khach Hang", x => x.MaKhachHang);
                    table.ForeignKey(
                        name: "FK_Khach Hang_LapTop_TenLapTop",
                        column: x => x.TenLapTop,
                        principalTable: "LapTop",
                        principalColumn: "TenLapTop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Khach Hang_TenLapTop",
                table: "Khach Hang",
                column: "TenLapTop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Khach Hang");
        }
    }
}
