using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel
{
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student("Ben Hunter", "E122", 4.5, 36000, Gender.Male, EducationForm.Internal);
            Student second = new Student("Tom Teddy", "T212", 4.0, 28000, Gender.Male, EducationForm.Blended);
            Student third = new Student("Vicky Fox", "D105", 4.5, 45000, Gender.Female, EducationForm.Internal);
            Student fourth = new Student("Sarah Connor", "S300", 3.6, 55000, Gender.Female, EducationForm.Extramural);
            Student fifth = new Student("Patrick Ramsey", "G120", 4.2, 22000, Gender.Male, EducationForm.Distance);
            Student sixth = new Student("Anthony Duclair", "S405", 3.9, 60000, Gender.Male, EducationForm.Internal);
            
            Student[] students = new Student[]
            {
                first, second, third, fourth, fifth, sixth
            };

            List<Student> list1 = new List<Student>(); // студенты у которых доход < 2 * MIN_PROFIT
            List<Student> list2 = new List<Student>(); // cтуденты у которых доход >= 2 * MIN_PROFIT

            const int MIN_PROFIT = 20000; // доход на члена семьи
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Profit < 2 * MIN_PROFIT)
                    list1.Add(students[i]);
                else
                    list2.Add(students[i]);
            }

            list1.Sort(ProfitCompare);
            list2.Sort(GradeCompare);

            List<Student> generalList = new List<Student>();
            for (int i = 0; i < students.Length; i++)
            {
                if (i < list1.Count)
                    generalList.Add(list1[i]);
                else
                    generalList.Add(list2[students.Length - (i+1)]);
            }

            foreach (var student in generalList)
            {
                student.Show();
            }
        }

        #region Сортировка по доходу
        static int ProfitCompare(Student s1, Student s2)
        {
            return s1.Profit.CompareTo(s2.Profit);
        }
        #endregion

        #region Сортировка по оценке
        static int GradeCompare(Student s1, Student s2)
        {
            return s1.AverageGrade.CompareTo(s2.AverageGrade);
        }
        #endregion
    }
}
