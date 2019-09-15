using Microsoft.EntityFrameworkCore.Migrations;

namespace Genesis.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactEntreprise_Contacts_ContactId",
                table: "ContactEntreprise");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactEntreprise_Entreprises_EntrepriseId",
                table: "ContactEntreprise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactEntreprise",
                table: "ContactEntreprise");

            migrationBuilder.RenameTable(
                name: "ContactEntreprise",
                newName: "ContactsEntreprises");

            migrationBuilder.RenameIndex(
                name: "IX_ContactEntreprise_EntrepriseId",
                table: "ContactsEntreprises",
                newName: "IX_ContactsEntreprises_EntrepriseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactsEntreprises",
                table: "ContactsEntreprises",
                columns: new[] { "ContactId", "EntrepriseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ContactsEntreprises_Contacts_ContactId",
                table: "ContactsEntreprises",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactsEntreprises_Entreprises_EntrepriseId",
                table: "ContactsEntreprises",
                column: "EntrepriseId",
                principalTable: "Entreprises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactsEntreprises_Contacts_ContactId",
                table: "ContactsEntreprises");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactsEntreprises_Entreprises_EntrepriseId",
                table: "ContactsEntreprises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactsEntreprises",
                table: "ContactsEntreprises");

            migrationBuilder.RenameTable(
                name: "ContactsEntreprises",
                newName: "ContactEntreprise");

            migrationBuilder.RenameIndex(
                name: "IX_ContactsEntreprises_EntrepriseId",
                table: "ContactEntreprise",
                newName: "IX_ContactEntreprise_EntrepriseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactEntreprise",
                table: "ContactEntreprise",
                columns: new[] { "ContactId", "EntrepriseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ContactEntreprise_Contacts_ContactId",
                table: "ContactEntreprise",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactEntreprise_Entreprises_EntrepriseId",
                table: "ContactEntreprise",
                column: "EntrepriseId",
                principalTable: "Entreprises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
