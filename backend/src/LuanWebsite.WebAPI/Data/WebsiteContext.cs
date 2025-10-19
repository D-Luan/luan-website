using LuanWebsite.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LuanWebsite.WebAPI.Data;

public class WebsiteContext : DbContext
{
    public WebsiteContext(DbContextOptions<WebsiteContext> options)
        : base(options)
    {
    }

    public DbSet<Article> Articles { get; set; }

    public DbSet<Project> Projects { get; set; }
}