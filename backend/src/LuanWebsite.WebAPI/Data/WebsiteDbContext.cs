using LuanWebsite.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LuanWebsite.WebAPI.Data;

public class WebsiteDbContext : DbContext
{
    public WebsiteDbContext(DbContextOptions<WebsiteDbContext> options)
        : base(options)
    {
    }

    public DbSet<Article> Articles { get; set; }

    public DbSet<Project> Projects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Article>().HasData(
            new Article
            {
                Id = 1,
                Title = "Meu Primeiro Artigo de Teste",
                Content = "Este é o conteúdo completo do meu primeiro artigo...",
                Category = "Programação",
                CreatedDate = new DateTime(2025, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                ProjectLink = null,
                ImageUrl = "assets/images/computacao.jpg"
            },
            new Article
            {
                Id = 2,
                Title = "Aprendendo JavaScript Puro",
                Content = "JavaScript puro é a base de tudo no frontend...",
                Category = "Frontend JavaScript",
                CreatedDate = new DateTime(2025, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                ProjectLink = "https://github.com/D-Luan/documentation-manager",
                ImageUrl = "assets/images/articlejst.jpg"
            });
    }
}