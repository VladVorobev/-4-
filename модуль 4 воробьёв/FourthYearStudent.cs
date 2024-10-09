﻿public class FourthYearStudent : IStudent
{
    private decimal gpa;
    private string name;

    public FourthYearStudent(string name, decimal gpa)
    {
        this.name = name;
        this.gpa = gpa;
    }

    public decimal GetGPA() => gpa;

    public int GetCourse() => 4; // Возвращаем номер курса

    public string GetName() => name;
}