using LuanWebsite.WebAPI.Models;
using LuanWebsite.WebAPI.Data;
using LuanWebsite.WebAPI.Dtos;
using Microsoft.EntityFrameworkCore;

namespace LuanWebsite.WebAPI.Services;

public class ArticleService : IArticleService
{
    private readonly WebsiteDbContext _context;

    public ArticleService(WebsiteDbContext context)
    {
        _context = context;
    }

    public async Task<List<ArticleResponseDto>> GetAllArticlesAsync()
    {
        var articleResponse = await _context.Articles
            .Select(r => new ArticleResponseDto
            {
                Id = r.Id,
                Title = r.Title,
                Content = r.Content,
                Category = r.Category,
                CreatedDate = r.CreatedDate,
                ProjectLink = r.ProjectLink,
                ImageUrl = r.ImageUrl
            })
            .ToListAsync();

        return articleResponse;
    }

    public async Task<ArticleResponseDto?> GetArticleByIdAsync(int id)
    {
        var articleResponse = await _context.Articles
            .Where(r => r.Id == id)
            .Select(r => new ArticleResponseDto
            {
                Id = r.Id,
                Title = r.Title,
                Content = r.Content,
                Category = r.Category,
                CreatedDate = r.CreatedDate,
                ProjectLink = r.ProjectLink,
                ImageUrl = r.ImageUrl
            })
            .SingleOrDefaultAsync();

        return articleResponse;
    }
}
