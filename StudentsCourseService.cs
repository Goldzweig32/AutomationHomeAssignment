namespace AutomationHomeAssignment;

public class StudentsCourseService
{
    List<StudentCourseGrade> items= new List<StudentCourseGrade>()
    {
        new StudentCourseGrade(){StudentId = 1,CourseId=1123,Grade = 34},
        new StudentCourseGrade(){StudentId = 1,CourseId=1124,Grade = 88},
        new StudentCourseGrade(){StudentId = 2,CourseId=1123,Grade = 65},
    };

    private List<StudentCourse> students = new List<StudentCourse>()
    {
        new StudentCourse(){StudentId = 1, Courses = {1123,1124}},
        new StudentCourse(){StudentId = 2, Courses = {1123}}
    };


    public List<AvgCourseGrade> GetAllCoursesAvgGrades()
    {
        List<AvgCourseGrade> AvgCourseGradeList = new List<AvgCourseGrade>();
        var courses = items.Select(x => x.CourseId).Distinct();
        foreach (var course in courses)
        {
            AvgCourseGradeList.Add(new AvgCourseGrade()
            {
                avgGrade = GetAvgCourseGradeByCourseId(course),
                CourseId = course
            });
        }

        return AvgCourseGradeList;
    }
    
    public List<int> GetStudentCourses(int studentId)
    {
        return students.FirstOrDefault(x => x.StudentId == studentId)?.Courses;
    }

    public double GetAvgCourseGradeByCourseId(int courseId)
    {
        var grades = items.Where(x => x.CourseId == courseId).Select(x => x.Grade).ToList();
        return grades.Average();
    }
}