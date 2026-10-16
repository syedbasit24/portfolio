using System.Collections.Generic;

namespace Portfolio.Data;

public class Experience
{
    public string Company { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public List<string> Responsibilities { get; set; } = new();
}
