using System.Collections.Generic;

namespace Portfolio.Data;

public class Project
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string FullDescription { get; set; } = string.Empty;
    public List<string> Technologies { get; set; } = new();
    public string Category { get; set; } = string.Empty;
    public string? GitHubUrl { get; set; }
    public string? LiveDemoUrl { get; set; }
    public bool IsExperienceBased { get; set; }
}
