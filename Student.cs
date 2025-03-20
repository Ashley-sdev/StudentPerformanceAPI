using System.ComponentModel.DataAnnotations;

namespace StudentPerformanceAPI
{
    public class Student
    {
        [Key]
        public int Id { get; set; }  // Primary key

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } // Student's full name (Required, max 100 chars)

        [Range(5, 100)]
        public int Age { get; set; } // Student's age, must be between 5 and 100

        [Required]
        [EmailAddress]
        public string Email { get; set; } // Student's email, validated as an email format

        [Required]
        [MaxLength(50)]
        public string Course { get; set; } // Student's enrolled course (Required, max 50 chars)
    }
}

