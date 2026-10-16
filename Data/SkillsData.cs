using System.Collections.Generic;

namespace Portfolio.Data;

public static class SkillsData
{
    public static List<SkillCategory> Categories => new()
    {
        new()
        {
            Name = "Programming Languages",
            Icon = "code",
            Skills = new List<string> { "C#", "JavaScript" }
        },
        new()
        {
            Name = "Backend & .NET",
            Icon = "server",
            Skills = new List<string> { "ASP.NET Core", "ASP.NET MVC", "ASP.NET Web Forms", "ADO.NET", "Entity Framework", "LINQ", "API Development", "Telerik UI" }
        },
        new()
        {
            Name = "Frontend",
            Icon = "layout",
            Skills = new List<string> { "HTML5", "CSS", "JavaScript", "jQuery", "AJAX", "Responsive Web Design" }
        },
        new()
        {
            Name = "Database",
            Icon = "database",
            Skills = new List<string> { "Microsoft SQL Server", "T-SQL", "Stored Procedures", "Database Diagrams", "SQL Query Optimization and Validation" }
        },
        new()
        {
            Name = "Development Tools",
            Icon = "tool",
            Skills = new List<string> { "Visual Studio 2022", "Visual Studio Code", "Postman", "Git", "Azure DevOps", "Crystal Reports" }
        }
    };
}
