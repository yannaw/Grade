using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook
    {
        public GradeBook()
        {
            name = "empty";
            grades = new List<float>();

        }

        public GradeStats ComputeStats()
        {
            GradeStats stats = new GradeStats();
 
            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighGrade = Math.Max(grade, stats.HighGrade);
                stats.LowGrade = Math.Min(grade, stats.LowGrade);

                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        internal void WriteGrades(TextWriter destination) {
            for(int i = 0; i < grades.Count; i++) {
                destination.WriteLine(grades[i]);
            }        }

        public void AddGrade(float f)
        {
            grades.Add(f);
        }
/*** Kompilatorn skapar fält om man har get; set och de inte finns specificerade. Dessa blir då privata.
***/
        public string Name {
            get {
                return name;
            }
            set {
                if(!String.IsNullOrEmpty(value)) {
                    //skapa event när värde ändras
                    if(name!=value) {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = name;
                        args.NewName = value;
                        //evoke event
                        NameChanged(this, args); //Skickar book jag jobbar på
                    }
                    name = value;
                }
            }
        }
        public NameChangedDelegate NameChanged;
        private string name;
         private List<float> grades;
    }
}
