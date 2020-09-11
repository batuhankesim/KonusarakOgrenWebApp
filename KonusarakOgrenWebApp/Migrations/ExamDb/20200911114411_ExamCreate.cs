using Microsoft.EntityFrameworkCore.Migrations;

namespace KonusarakOgrenWebApp.Migrations.ExamDb
{
    public partial class ExamCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamModels",
                columns: table => new
                {
                    SınavId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SoruBaslik = table.Column<string>(nullable: true),
                    SoruAciklama = table.Column<string>(nullable: true),
                    SoruBir = table.Column<string>(nullable: true),
                    SoruIki = table.Column<string>(nullable: true),
                    SoruUc = table.Column<string>(nullable: true),
                    SoruDort = table.Column<string>(nullable: true),
                    DogruCevap = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamModels", x => x.SınavId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamModels");
        }
    }
}
