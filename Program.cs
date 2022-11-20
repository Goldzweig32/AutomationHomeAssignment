using AutomationHomeAssignment;

static class Program
{
    static async Task Main(string[] args)
    {
        var stockService = new StockService();
       Console.WriteLine($"Max Revenue= {stockService.MaxRevenue(new []{5,4,9,2,8,7,7,9,6,8})}");

       var studentsService = new StudentsCourseService();
       foreach (var course in studentsService.GetStudentCourses(1))
       {
           Console.WriteLine($"Student 1 Course= {course}");
       }

       var avgList = studentsService.GetAllCoursesAvgGrades();
       foreach (var courseGrade in avgList)
       {
           Console.WriteLine($"Course = {courseGrade.CourseId}, Avg Grade = {courseGrade.avgGrade} ");
       }
       


    }
}