using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {

        private List<double> grades;
        private string name;

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
            var highGrade = double.MinValue;
            var lowGrade = 100.1;

            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The high grade is {highGrade}");
            Console.WriteLine($"The low grade is {lowGrade}");
        }
    }
}
