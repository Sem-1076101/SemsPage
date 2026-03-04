namespace PortfolioApi.Models;

public class Project 
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Tags { get; set; } = string.Empty;
    public string? GithubUrl { get; set; }
    public string? LiveUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}