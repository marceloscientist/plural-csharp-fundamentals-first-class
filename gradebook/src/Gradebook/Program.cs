using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book grades = new Book(); 
            grades.AddGrade(3.65);
            grades.AddGrade(4.56);
            grades.AddGrade(34.5);
             
            double result = grades.CalcAverage();

            Console.WriteLine(grades.ToString());
            
        }
    }
}
