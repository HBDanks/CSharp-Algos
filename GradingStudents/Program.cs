using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> grades = new List<int>() {73, 48, 62, 37};
            List<int> rounded = gradingStudents(grades);
            foreach(var grade in rounded)
            {
                Console.WriteLine(grade);
            }
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            for(int i = 0; i < grades.Count; i++)
            {
                if(grades[i] > 40 && grades[i]%5 > 2)
                {
                    grades[i] += 5 - grades[i]%5;
                };
            }
            return grades;
        }
    }
}
