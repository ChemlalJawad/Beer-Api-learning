using Microsoft.EntityFrameworkCore.Migrations;

namespace Genesis.Data.Migrations
{
    public partial class Migration15091 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entreprises_Contacts_ContactId",
                table: "Entreprises");

            migrationBuilder.DropIndex(
                name: "IX_Entreprises_ContactId",
                table: "Entreprises");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Entreprises");

            migrationBuilder.CreateTable(
                name: "ContactEntreprise",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false),
                    EntrepriseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEntreprise", x => new { x.ContactId, x.EntrepriseId });
                    table.ForeignKey(
                        name: "FK_ContactEntreprise_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactEntreprise_Entreprises_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactEntreprise_EntrepriseId",
                table: "ContactEntreprise",
                column: "EntrepriseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactEntreprise");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Entreprises",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entreprises_ContactId",
                table: "Entreprises",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entreprises_Contacts_ContactId",
                table: "Entreprises",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
