using Microsoft.EntityFrameworkCore.Migrations;

namespace Genesis.Data.Migrations
{
    public partial class jawad3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiegeSocial",
                table: "Entreprises");

            migrationBuilder.RenameColumn(
                name: "VatNumberEnt",
                table: "Entreprises",
                newName: "NumeroTva");

            migrationBuilder.RenameColumn(
                name: "VATNumber",
                table: "Contacts",
                newName: "NumeroTva");

            migrationBuilder.AddColumn<int>(
                name: "SiegeSocialId",
                table: "Entreprises",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entreprises_SiegeSocialId",
                table: "Entreprises",
                column: "SiegeSocialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entreprises_Adresse_SiegeSocialId",
                table: "Entreprises",
                column: "SiegeSocialId",
                principalTable: "Adresse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entreprises_Adresse_SiegeSocialId",
                table: "Entreprises");

            migrationBuilder.DropIndex(
                name: "IX_Entreprises_SiegeSocialId",
                table: "Entreprises");

            migrationBuilder.DropColumn(
                name: "SiegeSocialId",
                table: "Entreprises");

            migrationBuilder.RenameColumn(
                name: "NumeroTva",
                table: "Entreprises",
                newName: "VatNumberEnt");

            migrationBuilder.RenameColumn(
                name: "NumeroTva",
                table: "Contacts",
                newName: "VATNumber");

            migrationBuilder.AddColumn<string>(
                name: "SiegeSocial",
                table: "Entreprises",
                nullable: true);
        }
    }
}
