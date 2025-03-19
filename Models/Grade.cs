using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Grade
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string LetterGrade { get; set; } = string.Empty;

    [ForeignKey("Enrollment")]
    public int EnrollmentId { get; set; }
    
    public Enrollment? Enrollment { get; set; }
}