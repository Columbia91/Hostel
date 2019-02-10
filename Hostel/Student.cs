using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel
{
    class Student
    {
        public string FullName { get; set; }
        public string Group { get; set; }
        public double AverageGrade { get; set; }
        public int Profit { get; set; }
        public Gender Gender { get; set; }
        public EducationForm Form { get; set; }

        public Student(string fullName, string group, double avgGrade, int profit, Gender gender, EducationForm form)
        {
            FullName = fullName;
            Group = group;
            AverageGrade = avgGrade;
            Profit = profit;
            Gender = gender;
            Form = form;
        }
        public void Show()
        {
            Console.WriteLine("Полное имя: " + FullName +
                "\nГруппа: " + Group +
                "\nСредняя оценка: " + AverageGrade +
                "\nДоход: " + Profit +
                "\nПол: " + Gender +
                "\nФорма обучения: " + Form + "\n");
        }
    }
}
