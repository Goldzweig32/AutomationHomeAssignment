namespace AutomationHomeAssignment;

public class StudentCourse
{
    public StudentCourse()
    {
        Courses = new List<int>();
    }

    public int StudentId { get; set; }
    public List<int> Courses { get; set; }

}