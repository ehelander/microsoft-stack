
using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatistics()
    {
      var result = 0.0;
      var lowestGrade = double.MaxValue;
      var highestGrade = double.MinValue;
      foreach (double number in grades)
      {
        lowestGrade = Math.Min(number, lowestGrade);
        highestGrade = Math.Max(number, highestGrade);
        result += number;
      }
      result /= grades.Count;
      Console.WriteLine($"The highest grade is {highestGrade:N1}");
      Console.WriteLine($"The lowest grade is {lowestGrade:N1}");
      Console.WriteLine($"The average grade is {result:N1}");
    }

    private List<double> grades;
    private string name;
  }
}