using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotnetMvc.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddUserToDbSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    EmailAddress = table.Column<string>(type: "text", nullable: false),
                    JobTitle = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "Id", "EmailAddress", "FullName", "JobTitle", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "ashoknbasnetofficial@gmail.com", "Ashok Basnet", "Jonior Developer", "9863614474" },
                    { 2, "ashoknbasnetofficial@gmail.com", "Rajan Rijal", "Jonior Developer", "9863614474" },
                    { 3, "ashoknbasnetofficial@gmail.com", "Anu Thapa", "Techhincal Advistor", "9863614474" },
                    { 4, "rashikabhattarai59@gmail.com", "Rashika Bhattarai", "Student", "9863614474" },
                    { 5, "basnetpurna560@gmail.com", "Purna Bahadur Basnet", "Branch Manager", "9844666715" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfile");
        }
    }
}
