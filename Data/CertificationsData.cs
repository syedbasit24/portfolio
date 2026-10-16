using System.Collections.Generic;

namespace Portfolio.Data;

public static class CertificationsData
{
    public static List<Certification> Items => new()
    {
        new()
        {
            Name = "Web Development",
            Issuer = "Coursera / Johns Hopkins University",
            Date = "April 2021"
        },
        new()
        {
            Name = "Certified C# Basic",
            Issuer = "Cutshort",
            Date = "May 2023"
        },
        new()
        {
            Name = "Web Development Intern",
            Issuer = "Infowiz Software Solutions",
            Date = "January 2019 – February 2019"
        }
    };
}
