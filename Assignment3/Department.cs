namespace Assignment3;

public class Department : IDepartmentService
{
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public DateTime BudgetStart { get; set; }
    public DateTime BudgetEnd { get; set; }
    public Instructor Head { get; set; }
    private Course[] courses = new Course[20];
    private int courseCount = 0;

    public void SetHead(Instructor instructor)
    {
        Head = instructor;
    }

    public void AddCourse(Course course)
    {
        if (courseCount < courses.Length)
        {
            courses[courseCount++] = course;
        }
    }

    public Course[] GetCourses()
    {
        Course[] offeredCourses = new Course[courseCount];
        for (int i = 0; i < courseCount; i++)
        {
            offeredCourses[i] = courses[i];
        }
        return offeredCourses;
    }
}
