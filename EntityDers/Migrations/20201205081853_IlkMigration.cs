using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityDers.Migrations
{
    public partial class IlkMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
