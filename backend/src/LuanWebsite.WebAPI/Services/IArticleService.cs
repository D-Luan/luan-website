using LuanWebsite.WebAPI.Dtos;

namespace LuanWebsite.WebAPI.Services;

public interface IArticleService
{
    Task<List<ArticleResponseDto>> GetAllArticlesAsync();

    Task<ArticleResponseDto?> GetArticleByIdAsync(int id);
}