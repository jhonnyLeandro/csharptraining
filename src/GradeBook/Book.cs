using System;
using System.Collections.Generic;

namespace GradeBook{

    public class Book{
        
        private List<double> grades;
        public string Name;

        public Book(string name){
            Name = name;
            grades = new List<double>();
        }
        
        public void addGrade( double grade){
            grades.Add(grade);
        }

        public Statistics getStatistics(){
            var result = new Statistics();
            result.average = 0.0;
            result.high = double.MinValue;
            result.low = double.MaxValue;

            foreach( var grade in grades){
                result.high = Math.Max(grade, result.high);
                result.low = Math.Min(grade, result.low);
                result.average += grade;
            }
             result.average /= grades.Count;
            
            return result;
        }

        
    }
}