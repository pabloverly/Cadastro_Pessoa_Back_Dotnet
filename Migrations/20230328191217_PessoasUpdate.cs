using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPI.Migrations
{
    /// <inheritdoc />
    public partial class PessoasUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PessoaID",
                table: "Pessoas",
                newName: "PessoaId");

            migrationBuilder.RenameColumn(
                name: "Idate",
                table: "Pessoas",
                newName: "Idade");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "Pessoas",
                newName: "PessoaID");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Pessoas",
                newName: "Idate");
        }
    }
}
