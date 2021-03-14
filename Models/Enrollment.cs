namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
        //tinfo200:[2021-03-11-<tsepton>-dykstra1]- Addition of enum constructor that grades to be assigned to, allowing the grade to remain as null when no grade is applied
    }
    public class Enrollment
    {
        /*tinfo200:[2021-03-11-<tsepton>-dykstra1]- Addition of enrollment class with properties to control course enrollment information, including enrollment ID, course ID,
         *student ID, student's grade in the course, and the passing of a student object.
        */
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}