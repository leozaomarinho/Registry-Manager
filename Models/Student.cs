namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }         
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public DateTime EnrollmentDate { get; set; }
        public decimal GPA { get; set; }
        public bool IsActive { get; set; } = true;

        public override string ToString()
        {
            return $"Student(Id={Id}, Name={Name}, Email={Email}, Course={Course}, EnrollmentDate={EnrollmentDate.ToShortDateString()}, GPA={GPA}, IsActive={IsActive})";
        }


    }
};