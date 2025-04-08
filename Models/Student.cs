namespace StudentPerformanceAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CourseCode { get; set; }
        public double AssignmentMarks { get; set; }
        public double TestMarks { get; set; }

        // Computed property for average marks
        public double AverageMarks => (AssignmentMarks + TestMarks) / 2.0;

        // Determines if student qualifies for exam
        public bool QualifiesForExam()
        {
            return AverageMarks >= 50;
        }
    }
}
