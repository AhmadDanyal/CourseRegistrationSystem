using System;
using System.Collections.Generic;

public class Student : User
{
    // Additional properties (e.g., EnrollmentDate)
    public DateTime EnrollmentDate { get; set; }

    // Navigation property for Enrollments.
    public List<Enrollment>? Enrollments { get; set; }
}