﻿using System;
namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {

      var book = new Book("Scott's Grade Book");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.5);
      var stats = book.GetStatistics();

      Console.WriteLine($"The highest grade is {stats.High:N1}");
      Console.WriteLine($"The lowest grade is {stats.Low:N1}");
      Console.WriteLine($"The average grade is {stats.Average:N1}");
      Console.WriteLine($"The letter is {stats.Letter}");
    }
  }
}
