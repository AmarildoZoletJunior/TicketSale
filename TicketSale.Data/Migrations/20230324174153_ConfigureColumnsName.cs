using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketSale.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureColumnsName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonInfo_Surname",
                table: "Clients",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "PersonInfo_Name",
                table: "Clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PersonInfo_CPF",
                table: "Clients",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "PersonInfo_Birthday",
                table: "Clients",
                newName: "Birthday");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Clients",
                newName: "PersonInfo_Surname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clients",
                newName: "PersonInfo_Name");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Clients",
                newName: "PersonInfo_CPF");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Clients",
                newName: "PersonInfo_Birthday");
        }
    }
}
