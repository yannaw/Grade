using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeStats {
        public GradeStats() {
            HighGrade = 0;
            LowGrade = float.MaxValue;
        }

        public string LetterGrade {
            get {
                string result;
                switch(LetterGrade) {
                case "A": result = "Exellent"; break;
                case "B": result = "Good";break;
                case "C": result = "Average";break;
                case "D": result = "Poor";break;

                default:result = "Fail";
                    break;
                }
                if(AverageGrade>=90) {
                    result= "A";
                } else if(AverageGrade>=80) {
                    result = "B";
                } else if(AverageGrade>=70) {
                    result = "C";
                } else if(AverageGrade>=60) {
                    result = "D";
                } else {
                    result = "F";
                }
                return result;
            }
        }

        public string Description {
            get;
            set;
        }

        public float AverageGrade;
       public float HighGrade;
       public float LowGrade;
                  
    }
}
