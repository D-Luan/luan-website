using LuanWebsite.WebAPI.Dtos;
using LuanWebsite.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LuanWebsite.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArticlesController : ControllerBase
{
    private readonly IArticleService _articleService;

    public ArticlesController(IArticleService articleService)
    {
        _articleService = articleService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllArticlesAsync()
    {
        var articlesResponse = await _articleService.GetAllArticlesAsync();

        return Ok(articlesResponse);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetArticleByIdÂsync(int id)
    {
        var articleResponse = await _articleService.GetArticleByIdAsync(id);

        if (articleResponse == null)
        {
            return NotFound();
        }

        return Ok(articleResponse);
    }
}