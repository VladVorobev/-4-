public class SecondYearStudent : IStudent
{
    private decimal gpa;
    private string name;

    public SecondYearStudent(string name, decimal gpa)
    {
        this.name = name;
        this.gpa = gpa;
    }

    public decimal GetGPA() => gpa;

    public int GetCourse() => 2; // Возвращаем номер курса

    public string GetName() => name;
}