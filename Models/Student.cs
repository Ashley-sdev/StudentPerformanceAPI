namespace StudentPerformanceAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CourseCode { get; set; }

        // New properties
        public int AssignmentMarks { get; set; }
        public int TestMarks { get; set; }
        public int ExamMarks { get; set; }

        public double Average => (AssignmentMarks + TestMarks + ExamMarks) / 3.0;

        public bool QualifiesForExam => Average >= 50; // pass mark is 50
    }
}
