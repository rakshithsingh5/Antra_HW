namespace Assignment3;

public class Question3
{
    public static void Main(string[] args)
    {
        Student student = new Student
        {
            Name = "Alice",
            BirthDate = new DateTime(2000, 1, 1)
        };

        // Create a new instructor
        Instructor instructor = new Instructor
        {
            Name = "Dr. Smith",
            BirthDate = new DateTime(1975, 5, 20),
            Salary = 60000,
            JoinDate = new DateTime(2005, 8, 15)
        };

        // Create a new department
        Department csDepartment = new Department
        {
            Name = "Computer Science",
            Budget = 500000,
            BudgetStart = new DateTime(2023, 7, 1),
            BudgetEnd = new DateTime(2024, 6, 30),
            Head = instructor
        };

        // Create courses
        Course course1 = new Course { CourseName = "Introduction to Programming" };
        Course course2 = new Course { CourseName = "Data Structures" };

        // Add courses to the department
        csDepartment.AddCourse(course1);
        csDepartment.AddCourse(course2);

        // Enroll student in courses
        student.EnrollInCourse(course1);
        student.EnrollInCourse(course2);

        // Display information
        Console.WriteLine($"Student: {student.Name}, Age: {student.CalculateAge()}");
        Console.WriteLine($"Instructor: {instructor.Name}, Age: {instructor.CalculateAge()}, Salary: {instructor.CalculateSalary()}");
        Console.WriteLine($"Department: {csDepartment.Name}, Head: {csDepartment.Head.Name}");

        // Display enrolled courses
        Console.WriteLine($"Courses enrolled by {student.Name}:");
        foreach (var course in student.GetCourses())
        {
            Console.WriteLine(course.CourseName);
        }

    }
}