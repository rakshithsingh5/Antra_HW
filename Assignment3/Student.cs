namespace Assignment3;

public class Student : Person
{
    private Course[] courses = new Course[10];
    private int courseCount = 0;

    public override decimal CalculateSalary()
    {
        return 0; // Students typically don't have a salary in this context
    }

    public double CalculateGPA()
    {
        // Placeholder implementation for calculating GPA
        return 4.0;
    }

    public void EnrollInCourse(Course course)
    {
        if (courseCount < courses.Length)
        {
            courses[courseCount++] = course;
            course.AddStudent(this);
        }
    }

    public Course[] GetCourses()
    {
        Course[] enrolledCourses = new Course[courseCount];
        for (int i = 0; i < courseCount; i++)
        {
            enrolledCourses[i] = courses[i];
        }
        return enrolledCourses;
    }
}