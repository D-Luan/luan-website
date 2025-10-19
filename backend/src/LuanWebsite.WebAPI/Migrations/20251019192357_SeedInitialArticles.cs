using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LuanWebsite.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Category", "Content", "CreatedDate", "ProjectLink", "Title" },
                values: new object[,]
                {
                    { 1, "Programação", "Este é o conteúdo completo do meu primeiro artigo...", new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, "Meu Primeiro Artigo de Teste" },
                    { 2, "Frontend JavaScript", "JavaScript puro é a base de tudo no frontend...", new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "https://github.com/D-Luan/documentation-manager", "Aprendendo JavaScript Puro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
