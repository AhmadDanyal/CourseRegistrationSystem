using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Enrollment
{
    [Key]
    public int Id { get; set; }

    // Foreign key to the Student (child of User)
    [ForeignKey("Student")]
    public int StudentId { get; set; }
    public Student? Student { get; set; }

    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public Course? Course { get; set; }

    public Grade? Grade { get; set; }
}