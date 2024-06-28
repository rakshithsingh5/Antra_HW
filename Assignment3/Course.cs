namespace Assignment3;

public class Course : ICourseService
{
    public string CourseName { get; set; }
    private Student[] students = new Student[50];
    private int studentCount = 0;

    public void AddStudent(Student student)
    {
        if (studentCount < students.Length)
        {
            students[studentCount++] = student;
        }
    }

    public void AssignGrade(Student student, char grade)
    {
        // Placeholder implementation for assigning grades
    }

    public Student[] GetStudents()
    {
        Student[] enrolledStudents = new Student[studentCount];
        for (int i = 0; i < studentCount; i++)
        {
            enrolledStudents[i] = students[i];
        }
        return enrolledStudents;
    }
}