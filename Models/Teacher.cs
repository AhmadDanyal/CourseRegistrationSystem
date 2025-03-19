using System.Collections.Generic;

public class Teacher : User
{
    // Additional properties (e.g., department, specialization)
    public string? Department { get; set; }

    // Navigation property for Courses the teacher teaches.
    public List<Course>? Courses { get; set; }
}