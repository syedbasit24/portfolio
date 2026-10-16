using System.Collections.Generic;

namespace Portfolio.Data;

public static class ProjectsData
{
    public static List<Project> Items => new()
    {
        new()
        {
            Id = "bert-summarization",
            Name = "Text Summarization Using BERT",
            ShortDescription = "Fine-tuned BERT for text summarization using the CNN/DailyMail dataset.",
            FullDescription = "This project involved fine-tuning the BERT (Bidirectional Encoder Representations from Transformers) model for automatic text summarization. The model was trained on the CNN/DailyMail dataset, a large-scale dataset for abstractive and extractive summarization. The approach included data preprocessing, model fine-tuning, and evaluation using ROUGE metrics. The project demonstrated the application of modern NLP techniques for document summarization tasks.",
            Technologies = new List<string> { "Python", "BERT", "PyTorch", "NLP", "Deep Learning" },
            Category = "Data/AI",
            IsExperienceBased = false
        },
        new()
        {
            Id = "dynamic-visitor-form",
            Name = "Dynamic Database-Driven Visitor Form",
            ShortDescription = "A dynamic form that retrieves field definitions from a database and renders fields according to configuration.",
            FullDescription = "This project involved creating a highly configurable visitor management form where form fields, their order, column sections, tabs, and language options were all driven by database configuration. The system dynamically rendered UI components based on stored configuration, allowing for flexible form management without code changes. Key features included multi-tab support, language switching, and database-driven field ordering and validation.",
            Technologies = new List<string> { "ASP.NET MVC", "C#", "SQL Server", "JavaScript", "jQuery" },
            Category = "Full Stack",
            IsExperienceBased = true
        },
        new()
        {
            Id = "erp-crud-pdf",
            Name = "ERP CRUD and PDF Generation",
            ShortDescription = "ERP application features involving CRUD operations and PDF document generation.",
            FullDescription = "This project involved developing core CRUD (Create, Read, Update, Delete) functionality for an enterprise resource planning system. The application handled complex data models and business logic for various ERP modules. Additionally, the system included PDF generation capabilities for reports and documents, with customizable layouts and formatting. The work required careful attention to data integrity, transaction management, and document generation workflows.",
            Technologies = new List<string> { "ASP.NET Web Forms", "C#", "SQL Server", "Crystal Reports", "PDF Generation" },
            Category = ".NET",
            IsExperienceBased = true
        },
        new()
        {
            Id = "rate-management",
            Name = "Enterprise .NET Rate Management",
            ShortDescription = "Enterprise application development involving ASP.NET Web Forms, SQL Server stored procedures, and rate-related workflows.",
            FullDescription = "This enterprise application involved developing and maintaining rate management functionality using ASP.NET Web Forms and SQL Server. The work included developing complex stored procedures for rate calculations, implementing upload and override functionality, and ensuring data validation through both frontend and backend checks. The application handled tariff rate configurations, quarantine processes, and required close collaboration with QA and product teams. Backend troubleshooting and service refactoring were key responsibilities to ensure accurate record retrieval and data integrity.",
            Technologies = new List<string> { "ASP.NET Web Forms", "C#", "SQL Server", "Stored Procedures", "Azure DevOps" },
            Category = ".NET",
            IsExperienceBased = true
        }
    };
}
