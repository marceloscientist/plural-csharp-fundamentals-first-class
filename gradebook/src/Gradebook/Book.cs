using System;
using System.Collections.Generic;

namespace Gradebook {
    class Book {
        List<double> grades;
        double average; 
        public Book() {
            grades = new List<double>();        
        }

        public void AddGrade(double grade) {
            grades.Add(grade);
        }

        public double CalcAverage() {
            double sum = 0.0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            average = sum/grades.Count;
            return average;
        }

        public override string ToString()
        {
            return $"The average result is { average:N2}!";
        }

        
    }
}