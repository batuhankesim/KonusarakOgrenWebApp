using Microsoft.EntityFrameworkCore.Migrations;

namespace KonusarakOgrenWebApp.Migrations.ExamDb
{
    public partial class ExamDbCreate : Migration
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
                    SecenekBirA = table.Column<string>(nullable: true),
                    SecenekBirB = table.Column<string>(nullable: true),
                    SecenekBirC = table.Column<string>(nullable: true),
                    SecenekBirD = table.Column<string>(nullable: true),
                    SoruIki = table.Column<string>(nullable: true),
                    SecenekIkiA = table.Column<string>(nullable: true),
                    SecenekIkiB = table.Column<string>(nullable: true),
                    SecenekIkiC = table.Column<string>(nullable: true),
                    SecenekIkiD = table.Column<string>(nullable: true),
                    SoruUc = table.Column<string>(nullable: true),
                    SecenekUcA = table.Column<string>(nullable: true),
                    SecenekUcB = table.Column<string>(nullable: true),
                    SecenekUcC = table.Column<string>(nullable: true),
                    SecenekUcD = table.Column<string>(nullable: true),
                    SoruDort = table.Column<string>(nullable: true),
                    SecenekDortA = table.Column<string>(nullable: true),
                    SecenekDortB = table.Column<string>(nullable: true),
                    SecenekDortC = table.Column<string>(nullable: true),
                    SecenekDortD = table.Column<string>(nullable: true),
                    DogruCevapBir = table.Column<string>(nullable: true),
                    DogruCevapIki = table.Column<string>(nullable: true),
                    DogruCevapUc = table.Column<string>(nullable: true),
                    DogruCevapDort = table.Column<string>(nullable: true)
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
