using System.Collections.Generic;

namespace Portfolio.Data;

public static class ExperienceData
{
    public static List<Experience> Items => new()
    {
        new()
        {
            Company = "Revenue Technology Services (RTS)",
            Role = "Software Engineering / Software Developer",
            Duration = "September 2024 – Present",
            Responsibilities = new List<string>
            {
                "Set up and configured the application codebase from a DevOps repository and integrated Git with Visual Studio.",
                "Developed ASP.NET Web Forms pages and corresponding SQL Server stored procedures.",
                "Worked with data automation scheduler jobs and their associated stored procedures.",
                "Performed smoke testing and unit testing to validate application functionality.",
                "Investigated and resolved software defects and supported application stability.",
                "Participated in UAT smoke testing and verified product backlog item changes.",
                "Collaborated with QA and product teams to resolve issues tracked through Azure DevOps.",
                "Contributed to the Tariff Rate Loose module, working with UI functionality, uploads, overrides, quarantine processes, stored procedures, and business logic.",
                "Enhanced backend record retrieval to include both active and inactive users where required.",
                "Refactored .NET services and data access layers to improve the accuracy and consistency of record retrieval.",
                "Updated and validated SQL queries to maintain data integrity.",
                "Worked with Git, Azure DevOps work items, sprint boards, and technical documentation.",
                "Created database diagrams using SQL Server Management Studio."
            }
        },
        new()
        {
            Company = "Web Kraft IT Solutions",
            Role = "Software Developer",
            Duration = "March 2023 – August 2024",
            Responsibilities = new List<string>
            {
                "Assisted the development manager with software design and coding.",
                "Created a dynamic visitor form that generated fields from database configuration.",
                "Implemented database-driven field ordering, column sections, multiple tabs, and language-switching options.",
                "Developed CRUD operations for ERP software.",
                "Worked on PDF generation and document layout.",
                "Designed client-side and server-side application architecture.",
                "Built mobile-responsive features.",
                "Prepared technical documentation."
            }
        },
        new()
        {
            Company = "Sancy Berhad",
            Role = "Software Developer",
            Duration = "March 2022 – February 2023",
            Responsibilities = new List<string>
            {
                "Collaborated with development teams and product managers to deliver software solutions.",
                "Worked on laboratory and hospital-related software projects using the Serenity framework, Microsoft SQL Server, HTML5, .NET, and JavaScript.",
                "Participated in development meetings and learned the existing application codebase.",
                "Monitored internal application performance and responded to technical requests.",
                "Maintained application code and resolved minor defects."
            }
        }
    };
}
