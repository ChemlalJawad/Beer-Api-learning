using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Genesis.Data.Migrations
{
    public partial class jawad1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdresseId = table.Column<int>(nullable: true),
                    TypeContact = table.Column<int>(nullable: false),
                    VATNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entreprises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiegeSocial = table.Column<string>(nullable: true),
                    VatNumberEnt = table.Column<string>(nullable: true),
                    ContactId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreprises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entreprises_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adresse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rue = table.Column<string>(nullable: true),
                    Ville = table.Column<string>(nullable: true),
                    Pays = table.Column<string>(nullable: true),
                    EntrepriseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresse_Entreprises_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresse_EntrepriseId",
                table: "Adresse",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AdresseId",
                table: "Contacts",
                column: "AdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_Entreprises_ContactId",
                table: "Entreprises",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Adresse_AdresseId",
                table: "Contacts",
                column: "AdresseId",
                principalTable: "Adresse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresse_Entreprises_EntrepriseId",
                table: "Adresse");

            migrationBuilder.DropTable(
                name: "Entreprises");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Adresse");
        }
    }
}
