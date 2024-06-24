using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP10.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "souscategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_souscategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategorieSousCategorie",
                columns: table => new
                {
                    CategoriesID = table.Column<int>(type: "int", nullable: false),
                    SousCategoriesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieSousCategorie", x => new { x.CategoriesID, x.SousCategoriesID });
                    table.ForeignKey(
                        name: "FK_CategorieSousCategorie_categorie_CategoriesID",
                        column: x => x.CategoriesID,
                        principalTable: "categorie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorieSousCategorie_souscategories_SousCategoriesID",
                        column: x => x.SousCategoriesID,
                        principalTable: "souscategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorieSousCategorie_SousCategoriesID",
                table: "CategorieSousCategorie",
                column: "SousCategoriesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorieSousCategorie");

            migrationBuilder.DropTable(
                name: "categorie");

            migrationBuilder.DropTable(
                name: "souscategories");
        }
    }
}
