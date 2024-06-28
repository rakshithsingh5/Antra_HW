namespace Assignment3;

public interface ICourseService
{
    void AddStudent(Student student);
    void AssignGrade(Student student, char grade);
}