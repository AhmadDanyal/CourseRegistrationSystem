using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Course
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    // The teacher who teaches the course.
    [ForeignKey("Teacher")]
    public int TeacherId { get; set; }
    
    public Teacher? Teacher { get; set; }

    public List<Enrollment>? Enrollments { get; set; }
}