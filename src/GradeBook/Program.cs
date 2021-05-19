using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Jhonny's Grade Book");
            book.addGrade(9.4);
            book.addGrade(8.3);
            book.addGrade(6.3);
            book.addGrade(7.3);

            var stats = book.getStatistics();
            
            Console.WriteLine($"The average grade is {stats.average:N1}, and the highest grade is {stats.high} and the lowest grade is {stats.low}");
        }
    }
}
