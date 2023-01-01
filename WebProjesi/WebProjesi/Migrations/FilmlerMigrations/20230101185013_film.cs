using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProjesi.Migrations.FilmlerMigrations
{
    public partial class film : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmIsmi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    filmTuru = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    filmAciklamasi = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    filmResimURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmYorumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yorum = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FilmNumara = table.Column<int>(type: "int", nullable: false),
                    puan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yorumBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmYorumlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciKataloglar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filmNumara = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciKataloglar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "FilmYorumlari");

            migrationBuilder.DropTable(
                name: "KullaniciKataloglar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
