namespace LuanWebsite.WebAPI.Dtos;

public class ArticleResponseDto
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; }

    public string? ProjectLink { get; set; }

    public string? ImageUrl { get; set; }
}