using System.Collections.Generic;

namespace Portfolio.Data;

public class SkillCategory
{
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
}
