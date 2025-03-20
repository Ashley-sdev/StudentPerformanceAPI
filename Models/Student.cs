using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPerformanceAPI.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; } // Student's name (Required, max 25 chars)

        [Required]
        [MaxLength(25)]
        public string Surname { get; set; } // Student's last name (Required, max 100 chars)

        [Range(16, 100)]
        public int Age { get; set; } // Student's age, must be between 16 and 100

        [Required]
        [EmailAddress]
        public string Email { get; set; } // Student's email, validated as an email format

        [Required]
        [RegularExpression(@"^[A-Z]{3}\d{3}$", ErrorMessage = "Invalid Course Code. Format: AAA123 (e.g., BIT301)")]
        public string CourseCode { get; set; } // Must be like "BIT301"

        
    }
}

