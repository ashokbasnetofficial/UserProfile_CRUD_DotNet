using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotnetMvc.MigrationData.Migrations
{
    /// <inheritdoc />
    public partial class UserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
