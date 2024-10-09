public class FirstYearStudent : IStudent
{
    private decimal gpa;
    private string name;

    public FirstYearStudent(string name, decimal gpa)
    {
        this.name = name;
        this.gpa = gpa;
    }

    public decimal GetGPA() => gpa;

    public int GetCourse() => 1; // Возвращаем номер курса

    public string GetName() => name;
}