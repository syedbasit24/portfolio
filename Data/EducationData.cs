using System.Collections.Generic;

namespace Portfolio.Data;

public static class EducationData
{
    public static List<Education> Items => new()
    {
        new()
        {
            Degree = "Bachelor of Technology (B.Tech)",
            Field = "Computer Science and Engineering",
            Institution = "Islamic University of Science and Technology, Awantipora, Jammu & Kashmir",
            Year = "2021"
        }
    };
}
