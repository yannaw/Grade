using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade {
    class Program {
        static void Main(string[] args) {

/***
quick if-sats
turning operator: string pass = age>20? "pass":"nopass";
age>20 returnerar true/false vänsterled om true högerled om falskt

int[] ages ={2,3,4,5,6}
foreach(int value in ages){cw(value)}


***/

           GradeBook book = new GradeBook();

            book.AddGrade(2);
            book.AddGrade(23.5f);
            book.AddGrade(73);
            book.WriteGrades(Console.Out);

            GradeStats stats = book.ComputeStats();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighGrade);
            WriteResult("Lowest", stats.LowGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void WriteResult(string description, string result) {
            Console.WriteLine($"{description}:{result}", description, result);
        }
        private static void WriteResult(string description, float result) {
            Console.WriteLine($"{description}:{result:F2}",description, result);
        }

        public delegate void Writer(string message);
    }
}
