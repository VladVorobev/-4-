public class ThirdYearStudent : IStudent
{
    private decimal gpa;
    private string name;

    public ThirdYearStudent(string name, decimal gpa)
    {
        this.name = name;
        this.gpa = gpa;
    }

    public decimal GetGPA() => gpa;

    public int GetCourse() => 3; // Возвращаем номер курса

    public string GetName() => name;
}
